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
                Client.ConnectWindow connectWindow = new Client.ConnectWindow();
                var dialogResult = connectWindow.ShowDialog();
                if(dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    TcpServer tcpServer = new TcpServer(new TcpListener(IPAddress.Parse(connectWindow.Adress.Text), int.Parse(connectWindow.PortBox.Text)));

                    Console.WriteLine("Server start");
                    //Action<ReceivedParseInterface> b = tcpServer.Listening;
                    //tcpServer.Listening(new ReceivedParseTest(tcpServer));
                    tcpServer.Listening(new MathOperationMessageParse(tcpServer));
                }
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
