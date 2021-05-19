using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Chap21library;
using System.Threading;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Client : Form
    {
        uint msgId = 0;
        const int CHUNK_SIZE = 4096;
        const int serverPort = 5425; //연결할 서버 포트 번호
        bool booServer = false; //flag역할=> 버튼 on/off 용도
        StringBuilder Strings; //가변적인 String형식의 객체 생성
        Thread mainTh = null;
        TcpClient client = null;
        NetworkStream stream = null;
        string serverIp = null; //연결할 서버 IP 주소 
        string filepath = null; //전송할 파일 주소

        private String Logs
        {
            set
            {
                if (Strings == null)
                    Strings = new StringBuilder(500);
                if (Strings.Length >= (500 - value.Length))
                    Strings.Clear();
                Strings.AppendLine(value + " (" + DateTime.Now.ToLongTimeString() + ")");
                resultBox.Text = Strings.ToString() + "\r\n";
            }
        }

        void clientOpen()
        {
            try
            {
                mainTh = new Thread(new ThreadStart(Running));
                mainTh.Start();
                booServer = true;
            }
            catch (SocketException se)
            {
                resultBox.Text = se.ToString();
                booServer = false;
                return;
            }
        }

        void clientClose()
        {
            try
            {
                if (client != null) client.Close();
                if (stream != null) stream.Close();

                this.Invoke(new MethodInvoker(delegate ()
                {
                    Startbtn.Text = "Start";
                    Logs = String.Format("Client Close...");
                    booServer = false;
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
                IPEndPoint clientAddress = new IPEndPoint(0, 0);
                IPEndPoint serverAddress =
                    new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                this.Invoke(new MethodInvoker(delegate ()
                {
                    Logs = String.Format("클라이언트: {0}, 서버:{1}",
                    clientAddress.ToString(), serverAddress.ToString());
                    Startbtn.Text = "Stop";
                }));

                Message1 reqMsg = new Message1(); //요청 메세지
                reqMsg.Body = new BodyRequest() 
                {
                    FILESIZE = new FileInfo(filepath).Length,
                    FILENAME = Encoding.Default.GetBytes(filepath)
                };
                reqMsg.Header = new Header()
                {
                    MSGID = msgId++,
                    MSGTYPE = CONSTANTS.REQ_FILE_SEND,
                    BODYLEN = (uint)reqMsg.Body.GetSize(),
                    FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                    LASTMSG = CONSTANTS.LASTMSG,
                    SEQ = 0
                };

                client = new TcpClient(clientAddress);
                client.Connect(serverAddress);

                //디펜던시 인덱션?
                stream = client.GetStream();
                MessageUtil.Send(stream, reqMsg);  //서버로 전송한 메세지

                Message1 rspMsg = MessageUtil.Receive(stream); //서버로부터 받은 메세지

                if (rspMsg.Header.MSGTYPE != CONSTANTS.REP_FILE_SEND)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("정상적인 서버 응답이 아닙니다.{0}",
                        rspMsg.Header.MSGTYPE);
                    }));
                    return;
                }

                if (((BodyResponse)rspMsg.Body).RESPONSE == CONSTANTS.DENIED)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("서버에서 파일 전송을 거부했습니다.");
                    }));
                    return;
                }

                using (Stream fileStream = new FileStream(filepath, FileMode.Open)) //파일 전송부분
                {
                    byte[] rbytes = new byte[CHUNK_SIZE];

                    long readValue = BitConverter.ToInt64(rbytes, 0);

                    int totalRead = 0;
                    ushort msgSeq = 0;
                    byte fragmented =
                        (fileStream.Length < CHUNK_SIZE) ?
                        CONSTANTS.NOT_FRAGMENTED : CONSTANTS.FRAGMENTED;
                    while (totalRead < fileStream.Length)
                    {
                        int read = fileStream.Read(rbytes, 0, CHUNK_SIZE);
                        totalRead += read;
                        Message1 fileMsg = new Message1();

                        byte[] sendBytes = new byte[read];
                        Array.Copy(rbytes, 0, sendBytes, 0, read);

                        fileMsg.Body = new BodyData(sendBytes);
                        fileMsg.Header = new Header()
                        {
                            MSGID = msgId,
                            MSGTYPE = CONSTANTS.FILE_SEND_DATA,
                            BODYLEN = (uint)fileMsg.Body.GetSize(),
                            FRAGMENTED = fragmented,
                            LASTMSG = (totalRead < fileStream.Length) ?
                                      CONSTANTS.NOT_LASTMSG :
                                      CONSTANTS.LASTMSG,
                            SEQ = msgSeq++
                        };

                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            sendBar.PerformStep();
                        }));

                        MessageUtil.Send(stream, fileMsg);
                    }

                    Message1 rstMsg = MessageUtil.Receive(stream);
                    BodyResult result = ((BodyResult)rstMsg.Body);

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("파일 전송 성공 : {0}",
                        result.RESULT == CONSTANTS.SUCCESS);
                    }));
                } //end While

                stream.Close();
                client.Close();
            } //end try
            catch (SocketException se)
            {
                this.Invoke(new MethodInvoker(delegate ()
                { 
                    Logs = String.Format(se.ToString());
                    Startbtn.Text = "Start";
                }));

                booServer = false;
                return;
            }
        }

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e) //초기 화면 설정
        {
            sendBar.Style = ProgressBarStyle.Continuous;
            sendBar.Minimum = 0;
            sendBar.Maximum = 100;
            sendBar.Step = 1;
            sendBar.Value = 0;

            timer1.Start();
            timer1.Interval = 1000;
        }

        private void IpSetbtn_Click(object sender, EventArgs e)
        {
            serverIp = IpBox.Text;
            IpBox.Enabled = false;
            //Logs = String.Format(serverIp+" Connecting...");
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            if(openFile.FileNames.Length >0)
            {
                foreach(string filename in openFile.FileNames)
                {
                    this.pathBox.Text = filename.Substring(filename.LastIndexOf("\\") + 1);
                    filepath = pathBox.Text;  //이렇게 파일명만 잘라야 설정할때 중복되지 않음
                    pathBox.Enabled = false;
                }
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (!booServer)
            {
                clientOpen();
            }
            else
            {
                clientClose();
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Strings.Clear();
            resultBox.Text = Strings.ToString();
            sendBar.Value = 0;
            pathBox.Text = null;
            filepath = null;
            pathBox.Enabled = true;

            if(Startbtn.Text != "Stop")
            {
                IpBox.Text = null;
                serverIp = null;
                IpBox.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = "현재 시간 : " + DateTime.Now.ToLongTimeString();
        }
    }
}
