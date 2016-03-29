using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
   public  class Configuration
    {
        private static readonly char ReplacingValue;

        public static char GetReplacingValue()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString());
            int result = ReturnNumber(time.Year) + ReturnNumber(time.Day) + ReturnNumber(time.Month);
            result += ReturnNumber(time.Hour) + ReturnNumber(time.Minute) + ReturnNumber(time.Second);
            result %= 25;
            result += 65;
           char  ReplacingValue = (char)result;
            Console.WriteLine(ReplacingValue);
            return ReplacingValue;
        }
        public static int ReturnNumber(int number)
        {
            int result = number / 1000;
            number %= 1000;
            result += number / 100;
            number %= 100;
            result += number / 10;
            number %= 10;
            result += number;
            return result;
        }
    }
}
