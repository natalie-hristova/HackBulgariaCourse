using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DateSums
    {
        public static void PrintDatesWithGivenSum(int year, int sum)
        {
            int x = 0;
            int y = year % 10 + (year / 10) % 10 + (year / 100) % 10 + year / 1000;
            x = y;

            DateTime start = new DateTime(year, 01, 01);
            DateTime end = new DateTime(year, 12, 31);
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                x += i.Day % 10 + i.Day / 10;
                x += i.Month % 10 + i.Month / 10;
                if (x == sum)
               
                    Console.WriteLine("{0:dd MM yyyy}", i);
                    x = y;
                
                
            }
        }
    }
}
