using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Chap21_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4) //인수가 4개 보다 적을때 사용법 메세지 출력
            {
                Console.WriteLine(
                    "사용법 : {0} <Bind IP> <Bind Port> <Server IP> <Message>",
                    Process.GetCurrentProcess().ProcessName);
                return;
            }

            string bindIp = args[0]; //127.0.0.1
            int bindPort = Convert.ToInt32(args[1]); //포트0
            string serverIp = args[2]; //127.0.0.1
            const int serverPort = 5425;
            string message = args[3]; //Hello

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                Console.WriteLine("클라이언트: {0}, 서버:{1}",
                    clientAddress.ToString(), serverAddress.ToString());

                TcpClient client = new TcpClient(clientAddress); //클라이언트 객체 생성?

                client.Connect(serverAddress); //생성한 클라이언트를 서버주소로 연결

                byte[] data = Encoding.Default.GetBytes(message);

                NetworkStream stream = client.GetStream(); //

                stream.Write(data, 0, data.Length); //message 바이트 단위로 변환 한거 쓰기(전송)

                Console.WriteLine("송신: {0}", message);

                data = new byte[256];

                string responseData = "";

                int bytes = stream.Read(data, 0, data.Length); //읽어오기
                responseData = Encoding.Default.GetString(data, 0, bytes);
                Console.WriteLine("수신: {0}", responseData);

                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("클라이언트를 종료합니다.");
        }
    }
}
