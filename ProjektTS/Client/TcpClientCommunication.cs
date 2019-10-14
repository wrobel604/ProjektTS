using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class TcpClientCommunication
    {
        TcpClient tcpClient = null;
        NetworkStream stream = null;
        protected ReadStreamInterface readStream = null;
        Task messageReceiverTask = null;
        public ReadStreamInterface ReadStream
        {
            set { 
                readStream = value;
                messageReceiverTask = new Task(readStream.readStream);
                if (stream != null)
                {
                    messageReceiverTask.Start();
                }
            }
            get => readStream;
        }

        public TcpClientCommunication()
        {
            tcpClient = new TcpClient();
        }
        ~TcpClientCommunication() { stream = null; }
        public void connect(IPAddress ip, int port)
        {
            if (tcpClient != null) { 
                tcpClient.Connect(ip, port);
                if (tcpClient.Connected)
                {
                    Console.WriteLine($"Connect to {ip.ToString()}:{port}");
                    stream = tcpClient.GetStream();
                }
            }
        }
        public void send(string message)
        {
            if(stream!=null)
            {
                stream.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
            }
        }
        public void listening()
        {
            if(messageReceiverTask == null)
            {
                if(ReadStream == null) { throw new NullReferenceException("ReadStreamInterface ReadStream is null"); }
                
                messageReceiverTask = new Task(ReadStream.readStream);
            }
            if (ReadStream.streamToRead == null && tcpClient.Connected)
            {
                ReadStream.streamToRead = stream;
            }
            messageReceiverTask.Start();
        }
    }
}
