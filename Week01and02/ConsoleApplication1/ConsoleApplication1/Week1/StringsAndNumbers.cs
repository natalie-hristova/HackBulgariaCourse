using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringsAndNumbers
    {
        public static int SumOfNumbersInString(string n)
        {
            int x = 0, a = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (Char.IsDigit(n[i]))
                {
                    int b = int.Parse(n[i].ToString());
                    a = a * 10 + b;
                }
                else
                {
                    x += a;
                    a = 0;
                }
            }
            x += a;
            return x;
        }
    }
}
