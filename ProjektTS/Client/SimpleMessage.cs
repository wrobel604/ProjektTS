using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client
{
    public class SimpleMessage : MessageBuiderInterface
    {
        public List<double> numbers;
        public DateTime dateTime;
        //Według implementacji odpowiedź to status
        public string id, status, operation;

        public SimpleMessage() { numbers = new List<double>(); }
        public SimpleMessage(string message) : this(){
            Regex regex = new Regex(@"([A-Z]+):([a-zA-Z0-9\s]*);");
            MatchCollection matchCollection = regex.Matches(message);
            if (matchCollection.Count > 0)
            {
                foreach(Match match in matchCollection)
                {
                    if (match.Groups.Count == 3)
                    {
                        setValue(match.Groups[1].Value, match.Groups[2].Value);
                    }
                }
            }
        }
        public void setValue(string header, string value) {
            switch (header)
            {
                case "ID": id = value;break;
                case "OD": status = value;break;
                case "OP": operation = value;break;
                case "TIME": dateTime = new DateTime(long.Parse(value));break;
                case "LA": add(value);break;
            }
        }
        public bool add(string value)
        {
            //Normalne komendy
            Regex regex = new Regex(@"[a-zA-Z]+");
            Match match = regex.Match(value);
            if (match.Success)
            {
                string command = match.Value.ToLower();
                switch (command)
                {
                    case "send": return false;
                    case "dodaj": operation = command;break;
                    case "odejmij": operation = command;break;
                    case "mnozenie": operation = command;break;
                    case "dzielenie": operation = command;break;
                    case "log":
                    case "logorytm": operation = "log";break;
                    case "modulo": operation = command;break;
                    case "potega": operation = command;break;
                    case "pierwiastek": operation = command;break;
                    case "exit": operation = command;break;
                    //Komendy testowe
                    case "id": Console.WriteLine(id);break;
                    case "numbers": Console.WriteLine(numbersToString());break;
                    case "clear": numbers.Clear();break;
                    case "delete": numbers.RemoveAt(numbers.Count-1);break;
                }
                return true;
            }
            //Liczby
            regex = new Regex(@"([\-0-9]+,{0,1}[0-9]*)");
            MatchCollection matchCollection = regex.Matches(value);
            if (matchCollection.Count>0)
            {
                foreach (Match nr in matchCollection)
                {
                    //Console.WriteLine("_" + nr.Value + "_");
                    numbers.Add(double.Parse(nr.Value));
                }
                return true;
            }
            //Znaki
            regex = new Regex(@"([+\-*\/\^%])");
            match = regex.Match(value);
            if (match.Success)
            {
                switch (match.Value)
                {
                    case "+": return add("dodaj");
                    case "-": return add("odejmij");
                    case "*": return add("mnozenie");
                    case "/": return add("dzielenie");
                    case "%": return add("modulo");
                    case "^": return add("potega");
                }
            }
            return true;
        }
        public string numbersToString()
        {
            string res = "";
            foreach(double i in numbers)
            {
                res += i.ToString() + " ";
            }
            return res.Trim();
        }
        public string buildMessage()
        {
            return $"ID:{id};OD:{status};OP:{operation};TIME:{dateTime.Ticks.ToString()};LA:{numbersToString()};";
        }
    }
}
