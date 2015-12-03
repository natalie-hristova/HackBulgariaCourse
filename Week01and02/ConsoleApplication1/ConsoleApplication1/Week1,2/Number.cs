using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Number
    {
        public static List<int> NumberToList(int n)
        {
            int x;
            List<int> digits = new List<int>();
            while (n > 0)
            {
                x = n % 10;
                digits.Add(x);
                n = n / 10;
            }
            digits.Reverse();
            foreach (var item in digits)
            {
                Console.Write(item);
            }
            return digits;
        }
        public static int ListToNumber(List<int> digits)
        {

            int y = 0;

            foreach (var item in digits)
            {

                y = y * 10 + item;
            }

            return y;
        }
    }
}
