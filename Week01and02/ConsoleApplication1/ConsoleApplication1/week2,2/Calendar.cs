using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calendar
    {
        public static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            DateTime date = new DateTime(year, month, 1);
            string theMonth = date.ToString("MMMM", culture);
            Console.WriteLine(theMonth);

            int num;
            if (month == 4 || month == 6 || month == 9 || month == 11)
                num = 30;
            if (month == 2)
            {
                if (year % 4 != 0)
                    num = 28;
                else
                    num = 29;
            }
            else num = 30;
            for (int i = 0; i < 7; i++)
            {
                Console.Write(date.ToString("dddd", culture).PadLeft(1));
                Console.Write("    ");
                date = date.AddDays(1);
            }
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                string a = date.ToString("dddd", culture).PadLeft(1);

                for (int j = 0; j < a.Length; j++)
                {
                    Console.Write(" ");
                }
                if (i < 10)
                    Console.Write(" ");
                Console.Write(i);
                Console.Write(" ");
                date = date.AddDays(1);
                if (i % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
