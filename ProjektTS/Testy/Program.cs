using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy
{
    class Program
    {
        static void writeSimleMessage(Client.SimpleMessage simpleMessage)
        {
            Console.WriteLine(simpleMessage.dateTime.ToString());
            Console.WriteLine("ID: " + simpleMessage.id);
            Console.WriteLine("liczby: " + simpleMessage.numbersToString());
            Console.WriteLine("operacja: " + simpleMessage.operation);
            Console.WriteLine("status: " + simpleMessage.status);
        }
        static void Main(string[] args)
        {/*
            {
                Client.SimpleMessage simpleMessage = new Client.SimpleMessage($"ID:5;OD:1;OP:dodaj;TIME:{DateTime.Now.Ticks.ToString()};LA:;");
                writeSimleMessage(simpleMessage);
                Console.WriteLine();
                simpleMessage.add("+");
                Console.WriteLine("operacja: " + simpleMessage.operation);
                Console.Write(simpleMessage.add("3 5 -5") + ")");
                Console.WriteLine("operacja: " + simpleMessage.operation);
                Console.WriteLine($"liczby{simpleMessage.numbers.Count}: " + simpleMessage.numbersToString());
                simpleMessage.add("3,6 2.5");
                Console.WriteLine($"liczby{simpleMessage.numbers.Count}: " + simpleMessage.numbersToString());
                simpleMessage.add("odejmij");
                Console.WriteLine("operacja: " + simpleMessage.operation);
            }*/
            Client.SimpleMessage simpleMessage = new Client.SimpleMessage($"ID: 5;OD: 1;OP: dodaj;TIME: {DateTime.Now.Ticks.ToString()};L0: 5,5E-5;L1: 7,5;");
            Console.WriteLine(simpleMessage.ToString());

            Console.Read();
        }
    }
}
