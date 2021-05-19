using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Chap21library;
using System.Windows.Forms;
using System.Threading;

namespace ServerApp
{
    public partial class Server : Form
    {
        uint msgId = 0;
        const int bindPort = 5425; //포트 설정
        bool booServer = false; //flag역할=> 버튼 on/off 용도
        Thread mainTh;
        StringBuilder Strings = null;
        NetworkStream stream = null;
        TcpListener server = null;
        TcpClient client = null;
        string dir = null;
        string answer = null;

        private String Logs //문자열 쓰기 용도 프로퍼티
        {
            set
            {
                if (Strings == null)
                    Strings = new StringBuilder(500);
                if (Strings.Length >= (500 - value.Length))
                    Strings.Clear();
                Strings.AppendLine(value + " (" + DateTime.Now.ToLongTimeString() + ")"); //현재 시간 시분초까지 반영
                resultBox.Text = Strings.ToString() + "\r\n";
            }
        }

        void serverOpen()
        {
            try
            {
                mainTh = new Thread(new ThreadStart(Running));
                mainTh.Start();
                booServer = true;
            }
            catch (SocketException se)
            {
                Logs = String.Format(se.ToString());
                booServer = false;
                return;
            } 
        }


        void serverClose()
        {
            try
            {
                if (client != null) client.Close();
                if (stream != null) stream.Close();
                server.Stop(); // =>쓰레드 안에서 돌고 있어서 쓰레드 종료와 같다?

                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (!mainTh.IsAlive) //쓰레드 종료시 실행
                    {
                        IpText.Enabled = true;
                        Serverbtn.Text = "Start";
                        Logs = String.Format("Server Close...");
                        booServer = false;
                    }
                }));
            }
            catch (SocketException se)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    Logs = String.Format(se.ToString());
                }));
            }

        }

        void Running()
        {
            try 
            {
                IPEndPoint localAddress =
                  new IPEndPoint(0, bindPort); //0 => 컴퓨터 내에 할당된 어느 주소로 접근해도 서버에 접속 가능

                server = new TcpListener(localAddress); //
                server.Start();

                this.Invoke(new MethodInvoker(delegate ()
                {
                    IpText.Enabled = false;
                    Logs = String.Format("Server Open...");
                    Serverbtn.Text = "Stop";
                }));

                while (true) //
                {
                    client = server.AcceptTcpClient();

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("클라이언트 접속 : {0} ",
                       ((IPEndPoint)client.Client.RemoteEndPoint).ToString());
                    }));
                
                    stream = client.GetStream();

                    Message1 reqMsg = MessageUtil.Receive(stream);

                    if (reqMsg.Header.MSGTYPE != CONSTANTS.REQ_FILE_SEND)
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }

                    BodyRequest reqBody = (BodyRequest)reqMsg.Body;

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        if (MessageBox.Show("파일 업로드 요청이 왔습니다. 수락하시겠습니까?", "알림 메세지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            answer = "yes";
                    }));
                   
                    Message1 rspMsg = new Message1();
                    rspMsg.Body = new BodyResponse()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESPONSE = CONSTANTS.ACCEPTED
                    };
                    rspMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.REP_FILE_SEND,
                        BODYLEN = (uint)rspMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0
                    };

                    if (answer != "yes")
                    {
                        rspMsg.Body = new BodyResponse()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESPONSE = CONSTANTS.DENIED
                        };
                        MessageUtil.Send(stream, rspMsg);
                        stream.Close();
                        client.Close();

                        continue;
                    }
                    else
                        MessageUtil.Send(stream, rspMsg);

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("파일 전송을 시작합니다...");
                    }));

                    long fileSize = reqBody.FILESIZE;
                    string fileName = Encoding.Default.GetString(reqBody.FILENAME);
                    FileStream file =
                       new FileStream(dir + "\\" +fileName, FileMode.Create);

                    uint? dataMsgId = null;
                    ushort prevSeq = 0;
                    while ((reqMsg = MessageUtil.Receive(stream)) != null)
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            ReceiveBar.PerformStep();  
                        }));
                        if (reqMsg.Header.MSGTYPE != CONSTANTS.FILE_SEND_DATA)
                            break;

                        if (dataMsgId == null)
                            dataMsgId = reqMsg.Header.MSGID;
                        else
                        {
                            if (dataMsgId != reqMsg.Header.MSGID)
                                break;
                        }

                        if (prevSeq++ != reqMsg.Header.SEQ)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                Logs = String.Format("{0}, {1}", prevSeq, reqMsg.Header.SEQ);
                            }));
                            break;
                        }

                        file.Write(reqMsg.Body.GetBytes(), 0, reqMsg.Body.GetSize());

                        if (reqMsg.Header.LASTMSG == CONSTANTS.LASTMSG)
                            break;
                    }

                    long recvFileSize = file.Length;
                    file.Close();

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("수신 파일 크기 : {0} bytes", recvFileSize);
                    }));
                    
                    Message1 rstMsg = new Message1();
                    rstMsg.Body = new BodyResult()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESULT = CONSTANTS.SUCCESS
                    };
                    rstMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.FILE_SEND_RES,
                        BODYLEN = (uint)rstMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0
                    };

                    if (fileSize == recvFileSize)
                        MessageUtil.Send(stream, rstMsg);
                    else
                    {
                        rstMsg.Body = new BodyResult()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESULT = CONSTANTS.FAIL
                        };

                        MessageUtil.Send(stream, rstMsg);
                    }

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("파일 전송을 마쳤습니다...");
                    }));

                    stream.Close();
                    client.Close();
                } //end While
            } // end try
            catch
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if(mainTh.IsAlive)
                    {
                        Logs = String.Format("쓰레드 종료중...");
                        return;
                    }
                }));

                booServer = false;
                return;
            }
        }

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            ReceiveBar.Style = ProgressBarStyle.Continuous;
            ReceiveBar.Minimum = 0;
            ReceiveBar.Maximum = 100;
            ReceiveBar.Step = 1;
            ReceiveBar.Value = 0;

            timer1.Start();
            timer1.Interval = 1000;
        }

        private void Openbtn_Click(object sender, EventArgs e) //폴더 생성 및 설정
        {
            if (IpText.Text == "")
            {
                resultBox.Text = "사용법 : " + Process.GetCurrentProcess().ProcessName + " <Directory>\r\n";
                return;
            }
        
            dir = IpText.Text;

            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
                MessageBox.Show("폴더 생성", "알림 메세지", default, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("설정 완료", "알림 메세지", default, MessageBoxIcon.Exclamation);
                //dir = IpText.Text;
                return;
            }
        }

        private void Serverbtn_Click(object sender, EventArgs e) //서버 on/off & 클라이언트와의 통신
        {
            if(dir == null)
            {
                MessageBox.Show("경로 설정을 먼저 하세요!!", "알림 메세지", default, MessageBoxIcon.Exclamation);
                return;
            }


            if (!booServer)
            {
                serverOpen();
            }
            else
            {
                serverClose();
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Strings.Clear();
            resultBox.Text = Strings.ToString();
            ReceiveBar.Value = 0;
            if(Serverbtn.Text !="Stop")
            {
                IpText.Enabled = true;
                IpText.Text = null;
                dir = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = "현재 시간 : " + DateTime.Now.ToLongTimeString();
        }

    }//end class
}
