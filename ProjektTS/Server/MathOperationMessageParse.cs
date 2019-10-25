using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class MathOperationMessageParse : ReceivedParseInterface
    {
        static int id = 0;
        Client.SimpleMessage simpleMessage;
        TcpServer tcpServer;
        public MathOperationMessageParse(TcpServer server) { tcpServer = server; }
        IEnumerable<double> PairOperate(List<double> numbers, Func<double, double, double> func)
        {
            if (numbers.Count >= 1)
            {
                IEnumerable<double> pary = numbers.Take(2);
                IEnumerable<double> array;
                do
                {
                    array = numbers.Skip(2);
                    yield return func(pary.First(), pary.Last());
                    pary = array.Take(2);
                } while (pary.Count() == 2);
            }
        }
        public string parseReceived(string message)
        {
            simpleMessage = new Client.SimpleMessage(message);
            Console.WriteLine("Odebrano:");
            Console.WriteLine(message);
            Console.WriteLine(simpleMessage.ToString());
            simpleMessage.status = "0";
            List<double> result = new List<double>();
            switch (simpleMessage.operation)
            {
                case "dodaj": {
                        double suma = 0;
                        try
                        {
                            foreach (double i in simpleMessage.numbers) { suma += i; }
                            result.Add(suma);
                        }
                        catch(ArgumentOutOfRangeException e)
                        {
                            simpleMessage.status = "1";
                        }
                    } break;
                case "odejmij":
                    {
                        int size = simpleMessage.numbers.Count-1;
                        for(int i = 0; i < size; ++i)
                        {
                            result.Add(simpleMessage.numbers[i] - simpleMessage.numbers[i + 1]);
                        }
                    } break;
                case "mnozenie": {
                        double iloczyn = 1;
                        try
                        {
                            foreach (double i in simpleMessage.numbers) { iloczyn *= i; }
                            result.Add(iloczyn);
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            simpleMessage.status = "1";
                        }

                    } break;
                case "dzielenie": {
                        int size = simpleMessage.numbers.Count - 1;
                        for (int i = 0; i < size; ++i)
                        {
                            if(simpleMessage.numbers[i + 1] != 0) 
                            { result.Add(simpleMessage.numbers[i] / simpleMessage.numbers[i + 1]); } else
                            {
                                simpleMessage.status = "2";
                            }
                           
                        }
                    } break;
                case "log":
                case "logarytm": {
                        int size = simpleMessage.numbers.Count - 1;
                        for (int i = 0; i < size; ++i)
                        {
                            if (simpleMessage.numbers[i + 1] != 0 && simpleMessage.numbers[i]!=0) { 
                                result.Add(Math.Log(simpleMessage.numbers[i + 1], simpleMessage.numbers[i]));
                            }
                            else
                            {
                                simpleMessage.status = "2";
                            }

                        }
                    } break;
                case "modulo": {
                        int size = simpleMessage.numbers.Count - 1;
                        for (int i = 0; i < size; ++i)
                        {
                            if (simpleMessage.numbers[i + 1] != 0) { result.Add(simpleMessage.numbers[i] % simpleMessage.numbers[i + 1]); }
                            else
                            {
                                simpleMessage.status = "2";
                            }

                        }
                    } break;
                case "potega": {
                        try
                        {
                            int size = simpleMessage.numbers.Count - 1;
                            for (int i = 0; i < size; ++i)
                            {
                                double number = Math.Pow(simpleMessage.numbers[i], simpleMessage.numbers[i + 1]);
                                if(double.IsNaN(number) || double.IsInfinity(number))
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                else { }
                                result.Add(number);
                            }
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            simpleMessage.status = "1";
                        }
                    } break;
                case "pierwiastek": {
                        foreach(double d in simpleMessage.numbers)
                        {
                            if (d < 0) { simpleMessage.status = "3"; } else
                            {
                                result.Add(Math.Sqrt(d));
                            }
                        }
                    } break;
                case "exit": {
                        tcpServer.CloseClient(simpleMessage.buildMessage());
                        return "";
                    } 
            }
            simpleMessage.numbers = result;
            if (simpleMessage.id == "") { simpleMessage.id = (++id).ToString(); }
            simpleMessage.dateTime = DateTime.Now;

            Console.WriteLine("Wysłano:");
            Console.WriteLine(simpleMessage.ToString());
            return simpleMessage.buildMessage();
        }
    }
}
