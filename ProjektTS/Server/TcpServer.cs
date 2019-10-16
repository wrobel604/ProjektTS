using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public class TcpServer
    {
        protected TcpListener tcpListener = null;
        protected byte[] streamByteArray = null;
        protected TcpClient tcpClient;

        public int StreamBufferSize
        {
            get => (streamByteArray == null)? 0: streamByteArray.Length;
            set => streamByteArray = new byte[value];
        }
        public TcpServer(TcpListener listener, int buffersize = 256)
        {
            if (listener == null) throw new ArgumentNullException("Server cannot be null value");
            tcpListener = listener;
            streamByteArray = new byte[buffersize];
            try
            {
                listener.Start();
                streamByteArray = new byte[buffersize];
            }catch(SocketException e)
            {
                Console.WriteLine("Server cannot start");
                Console.WriteLine(e.ToString());
            }
        }
        public TcpServer(IPAddress ip, int port) : this(new TcpListener(ip, port)) { }
        ~TcpServer()
        {
            if (tcpListener != null)
            {
                tcpListener.Stop();
            }
        }
        public void Listening(ReceivedParseInterface receivedparse)
        {
            NetworkStream networkStream;
            int receiveddatasize = 0;
            string message = null, ansver = null;
            byte[] ansverByteArray = null;
            try
            {
                while (true)
                {
                    tcpClient = tcpListener.AcceptTcpClient();
                    networkStream = tcpClient.GetStream();
                    while(tcpClient.Connected && (receiveddatasize = networkStream.Read(streamByteArray, 0, streamByteArray.Length)) != 0)
                    {
                        message = Encoding.ASCII.GetString(streamByteArray).Substring(0,receiveddatasize);
                        ansver = receivedparse.parseReceived(message);
                        if (ansver.Length > 0) {
                            ansverByteArray = Encoding.ASCII.GetBytes(ansver);
                            networkStream.Write(ansverByteArray, 0, ansverByteArray.Length);
                        }
                    }
                    Console.WriteLine("Rozlaczono z klientem");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void CloseClient()
        {
            if(tcpClient != null)
            {
                tcpClient.Close();
            }
        }
    }
}
