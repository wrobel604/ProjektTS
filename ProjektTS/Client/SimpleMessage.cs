﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client
{
    public class SimpleMessage : MessageBuiderInterface
    {
        public static readonly string[] statusName = { 
            "OK", 
            "Przepełnienie bufora zmiennej", 
            "Dzielenie przez zero", 
            "Nie można pierwiastkować liczb ujemnych", 
            "Podano zbyt mało liczb", 
            "Argumenty logarytmu mniejsze bądź równe 0"};
        public List<double> numbers;
        public DateTime dateTime;
        //Według implementacji odpowiedź to status
        public string id, status, operation;

        public SimpleMessage() { numbers = new List<double>(); }
        //Konstruktor tworzący obiekt na podstawie odebranej wiadomości
        public SimpleMessage(string message) : this(){
            Regex regex = new Regex(@"([A-Za-z0-9]+): ([\-,a-zA-Z0-9\s+]*);");
            MatchCollection matchCollection = regex.Matches(message);
            if (matchCollection.Count > 0)
            {
                foreach(Match match in matchCollection)
                {
                    if (match.Groups.Count == 3)
                    {
                        Console.WriteLine("Test:\t"+match.Groups[1].Value + "\t"+match.Groups[2].Value);
                        setValue(match.Groups[1].Value, match.Groups[2].Value);
                    }
                }
            }
        }
        public void setValue(string header, string value) {
            // Console.Write(header+"\t"+value+"\t");
            switch (header)
            {
                case "Identyfikator": Console.WriteLine($"${value}$"); id = value;break;
                case "Status": status = value;break;
                case "Operacja": operation = value;break;
                case "Czas": dateTime = new DateTime(long.Parse(value));break;
                default:
                    Regex regex = new Regex(@"(L[0-9]+)");
                    if (regex.IsMatch(header)) {
                        double conv;
                        if(double.TryParse(value, out conv))
                        {
                            addNumber(conv);
                        }
                    }

                    break;
            }
        }
        public void addNumber(double nr)
        {
            numbers.Add(nr);
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
                    case "op":
                    case "operation": Console.WriteLine(operation);break;
                    case "message": Console.WriteLine(ToString());break;
                }
                return true;
            }
            //Znaki
            regex = new Regex(@"^([+\-*\/\^%])$");
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
                return true;
            }
            //Liczby
            /*
            regex = new Regex(@"\s*(\-{0,1}[0-9]+,{0,1}[0-9]*)\s*");
            MatchCollection matchCollection = regex.Matches(value);
            if (matchCollection.Count>0)
            {
                foreach (Match nr in matchCollection)
                {
                    //Console.Write("_" + nr.Value + "_");
                    numbers.Add(double.Parse(nr.Value));
                }
                //Console.WriteLine();
                return true;
            }*/
            string[] numbs = value.Split(' ');
            foreach(string n in numbs) {
                setValue("L0", n);
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
        //Metoda generująca wiadomość do wysłania
        public string buildMessage()
        {
            string res = $"Identyfikator: {id};Status: {status};Operacja: {operation};Czas: {DateTime.Now.Ticks.ToString()};";
            int i=0;
            foreach(double nr in numbers){
                res += $"L{i++}: {nr};";
            }
            return res;
        }
        public override string ToString()
        {
            string result = $"Czas: {dateTime}\nIdentyfikator: {id}\nCzas: {dateTime.Ticks.ToString()}\nStatus: {status}\nOperacja: {operation}\nLiczby: {numbersToString()}\n";
            return result;
        }

    }
}
