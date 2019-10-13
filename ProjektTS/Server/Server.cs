using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            /*
            TcpListener tcpListener = null;
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 17);
                tcpListener.Start();
                Console.WriteLine("Server start");
                TcpClient client = null;
                NetworkStream stream = null;
                String data = null;
                byte[] streamByte = new byte[256];
                int i;

                while (true)
                {
                    i = 0;
                    data = null;
                    client = tcpListener.AcceptTcpClient();
                    stream = client.GetStream();
                    while ((i = stream.Read(streamByte, 0, streamByte.Length)) != 0)
                    {
                        Console.WriteLine(i);
                        data = Encoding.ASCII.GetString(streamByte).Substring(0,i);
                        Console.WriteLine(data.Length);
                        Console.WriteLine(data);
                        i = 0;
                    }
                    client.Close();
                }
                
            }
            catch(SocketException e)
            {
                Console.WriteLine($"SocketException: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {
                if (tcpListener != null) { tcpListener.Stop(); }
                Console.WriteLine("Server stop");
            }*/

            TcpServer tcpServer = new TcpServer(new TcpListener(IPAddress.Parse("127.0.0.1"), 17));
            Console.WriteLine("Server start");
            tcpServer.Listening(new ReceivedParseTest());

            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
