using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClientCommunication tcpClient = new TcpClientCommunication();
                tcpClient.ReadStream = new ReadAnswerTest();
                tcpClient.connect(IPAddress.Parse("127.0.0.1"), 17);
                tcpClient.listening();
                string message = null;
                while (message != "exit")
                {
                    message = Console.ReadLine();
                    tcpClient.send(message);
                }
            }catch(Exception e) { Console.WriteLine(e.ToString()); }
            
            Console.WriteLine("END");
            Console.Read();
        }
    }
}
