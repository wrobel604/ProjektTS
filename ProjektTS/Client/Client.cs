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
        static void receivedEvent(NetworkStream stream)
        {
            int size;
            byte[] data = new byte[256]; string message = null;
            
            while((size = stream.Read(data, 0, data.Length)) != 0)
            {
                message = Encoding.ASCII.GetString(data);
                Console.WriteLine(message);
            }
        }
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            NetworkStream stream = null;
            byte[] data = null;string message = null;
            //Task receivedTask = new Task(receivedEvent, stream);//receivedEvent(stream);
            //receivedTask.Start();
            try
            {
                client.Connect(IPAddress.Parse("127.0.0.1"), 17);
                stream = client.GetStream();
                Console.WriteLine("Polaczono");
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
                //receivedTask.Dispose();
                client.Close();
            }
            
        }
    }
}
