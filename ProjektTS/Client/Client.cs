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
        static void Main(string[] args)
        {
            try
            {
                TcpClientCommunication tcpClient = new TcpClientCommunication();
                tcpClient.ReadStream = new ReadAnswerTest();
                ConnectWindow connectWindow = new ConnectWindow();
                var dialogResult = connectWindow.ShowDialog();
                if(dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    tcpClient.connect(IPAddress.Parse(connectWindow.Adress.Text), int.Parse(connectWindow.PortBox.Text));
                    if (tcpClient.isConnected)
                    {
                        string message = null;
                        //tcpClient.listening();
                        SimpleMessage simpleMessage = new SimpleMessage();
                        tcpClient.send(simpleMessage.buildMessage());
                        simpleMessage = new SimpleMessage(tcpClient.receiveMessage());
                        Console.WriteLine($"Połączono z serwerem o adresie {connectWindow.Adress.Text} na porcie {connectWindow.PortBox.Text}");
                        Console.WriteLine("Możesz wpisywać liczby oddzielone spacją (w liczbach zmiennoprzecinkowych jest używany ',') lub znak/nazwę działania, które chcesz wykonać (jeśli wpiszesz następne działanie, poprzednie zostanie zastąpione)");
                        Console.WriteLine("Dostępne działania:");
                        Console.WriteLine("- dodaj (+)");
                        Console.WriteLine("- odejmij (-)");
                        Console.WriteLine("- mnozenie (*)");
                        Console.WriteLine("- dzielenie (/)");
                        Console.WriteLine("- modulo (%)");
                        Console.WriteLine("- potega (^)");
                        Console.WriteLine("- logarytm (log)");
                        Console.WriteLine("- pierwiastek");
                        Console.WriteLine("- message ");
                        Console.WriteLine("- exit - rozłącz z serwerem");
                        Console.WriteLine("- send - wyślij działanie");
                        while (simpleMessage.operation != "exit")
                        {
                            do
                            {
                                Console.Write("ID: "+simpleMessage.id + "> ");
                                message = Console.ReadLine();
                            } while (simpleMessage.add(message));
                            tcpClient.send(simpleMessage.buildMessage());
                            message = tcpClient.receiveMessage();
                            simpleMessage = new SimpleMessage(message);
                            Console.WriteLine("Status odpowiedzi: " + SimpleMessage.statusName[int.Parse(simpleMessage.status)]);
                            Console.WriteLine(simpleMessage.dateTime.ToString() + $" - Wynik) {simpleMessage.numbersToString()}");
                        }
                        tcpClient.Close();
                    }
                    else
                    {
                        Console.WriteLine("Nie udało się połączyć z serwerem");
                    }
                }
            }catch(Exception e) { Console.WriteLine(e.ToString()); }
            
            Console.WriteLine("END");
            Console.Read();
        }
    }
}
