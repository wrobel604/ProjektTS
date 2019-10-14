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
        /*static NetworkStream stream = null;
        static void receivedEvent()
        {
            int size;
            byte[] data = new byte[256]; string message = null;

            while (stream != null && (size = stream.Read(data, 0, data.Length)) != 0)
            {
                message = Encoding.ASCII.GetString(data).Substring(0,size);
                Console.WriteLine(message);
            }
        }*/
        static void Main(string[] args)
        {
            /*TcpClient client = new TcpClient();
            
            byte[] data = null;string message = null;
            Task task = new Task(receivedEvent);
            try
            {
                client.Connect(IPAddress.Parse("127.0.0.1"), 17);
                stream = client.GetStream();
                Console.WriteLine("Polaczono");
                task.Start();
                while (client.Connected)
                {
                    message = Console.ReadLine();
                    data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    
                }
            }catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {
                stream = null;
                task.Dispose();
                client.Close();
            }*/
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
