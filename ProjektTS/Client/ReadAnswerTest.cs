using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public class ReadAnswerTest : ReadStreamInterface
    {
        protected NetworkStream stream;
        protected int dataSize;
        public NetworkStream streamToRead
        {
            set => stream = value;
            get => stream;
        }
        public ReadAnswerTest(NetworkStream networkStream =null, int datasize = 256)
        {
            stream = networkStream;
            dataSize = datasize;
        }

        public void readStream()
        {
            byte[] streamByteArray = new byte[dataSize];
            int i = 0;
            string rec;
            while (streamToRead != null && (i = stream.Read(streamByteArray, 0, dataSize)) != 0)
            {
                rec = Encoding.ASCII.GetString(streamByteArray).Substring(0, i);
                Console.WriteLine(rec);
            }
        }
    }
}
