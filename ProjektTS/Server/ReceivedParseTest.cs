using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ReceivedParseTest : ReceivedParseInterface
    {
        public string parseReceived(string message)
        {
            Console.WriteLine(message + " - Length = " + message.Length.ToString());
            return message + " - Length = " + message.Length.ToString();
        }
    }
}
