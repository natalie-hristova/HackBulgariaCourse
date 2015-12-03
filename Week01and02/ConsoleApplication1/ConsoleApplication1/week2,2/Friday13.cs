using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Friday13
    {
        public static int UnfortunateFridays(int startYear, int endYear)
        {
            int br = 0;
            DateTime start = new DateTime(startYear, 01, 01);
            DateTime end = new DateTime(endYear, 12, 31);
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Friday && i.Day == 13)
                {
                    br++;
                }
            }
            return br;
        }
    }
}
