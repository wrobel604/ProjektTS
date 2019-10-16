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
            try
            {
                TcpServer tcpServer = new TcpServer(new TcpListener(IPAddress.Parse("127.0.0.1"), 17));
                Console.WriteLine("Server start");
                //Action<ReceivedParseInterface> b = tcpServer.Listening;
                tcpServer.Listening(new ReceivedParseTest(tcpServer));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("END");
            Console.ReadKey();
        }

    }
}
