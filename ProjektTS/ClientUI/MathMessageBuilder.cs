using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI
{
    class MathMessageBuilder : Client.MessageBuilder
    {
        protected string id, status;
        string operation, x, y;
        public MathMessageBuilder() { }
        public string buildMessage()
        {
            string message = $"id:{((id.Length==0)? "0":id)};status:{status};time:{DateTime.Now.ToString()};";
            if(id.Length != 0)
            {
                message += $"operation:{operation};args:{x},{y};";
            }
            return message;
        }
    }
}
