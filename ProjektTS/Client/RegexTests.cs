using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client
{
    public static class RegexTests
    {
        public static bool checkIP(string ip)
        {
            string to255Range = @"((((([0-9]{1})|([1-9][0-9]))|(1[0-9]{2}))|(2[0-4][0-9]))|(25[0-5]))";
            Regex regex = new Regex($@"^{to255Range}\.{to255Range}\.{to255Range}\.{to255Range}$");
            return regex.IsMatch(ip);
        }
        public static bool isPortNumber(string port)
        {
            Regex regex = new Regex("^[1-9][0-9]*$");
            return regex.Match(port).Success;
        }
        public static bool isNumber(string text)
        {
            Regex regex = new Regex("^([1-9][0-9]*)|([-1-9][0-9]+)$");
            return regex.IsMatch(text);
        }
    }
}
