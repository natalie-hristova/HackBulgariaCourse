using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Digitss
    {

        public static int CountDigits(int n)
        {
            int x = 1;
            int br = 0;
            while (x != 0)
            {
                x = n / 10;
                n = n / 10;
                br++;
            }
            return br;
        }


        public static int SumDigits(int n)
        {
            int br = 0;
            for (int i = CountDigits(n); i > 0; i--)
            {
                br += n % 10;
                n = n / 10;
            }
            return br;
        }
        public static int FactorialDigits(int n)
        {
            int br ;
            int f;
            int sum = 0;
            for (int i = CountDigits(n); i > 0; i--)
            {
                br = n % 10;
                f = 1;
                for(int j=1;j<= br; j++)
                {
                   f = f * j;
                }
                sum = f + sum;
                n = n / 10;
            }
            return sum;

        }
    }
}
