using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ReceivedParseTest : ReceivedParseInterface
    {
        protected TcpServer serverOperate;

        public ReceivedParseTest(TcpServer server)
        {
            serverOperate = server;
        }
        public string parseReceived(string message)
        {
            Console.WriteLine(message + " - Length = " + message.Length.ToString());
            if (message == "exit") { serverOperate.CloseClient();return ""; }
            return message + " - Length = " + message.Length.ToString();
        }
    }
}
