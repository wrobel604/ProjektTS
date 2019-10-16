using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    class ReceivedData : Client.ReadStreamInterface
    {
        protected NetworkStream stream;
        protected int dataSize;
        public TextBox textBox;
        public ReceivedData(int datasize = 256)
        {
            dataSize = datasize;
        }
        public NetworkStream streamToRead
        {
            set => stream = value;
            get => stream;
        }
        public void readStream()
        {
            byte[] streamByteArray = new byte[dataSize];
            int i = 0;
            string message;
            while (streamToRead != null && (i = stream.Read(streamByteArray, 0, dataSize)) != 0)
            {
                message = Encoding.ASCII.GetString(streamByteArray).Substring(0, i);
                textBox.Text += message + "\n";
            }
        }
    }
}
