using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class Time
    {

        public int hour;
        public int min;
        public int sec;
        public int day;
        public int month;
        public int year;


        public Time(int hour, int min, int sec, int day, int month, int year)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            string x = string.Format("{0}:{1}:{2} {3}.{4}.{5}", hour, min, sec, day, month, year);
            Console.WriteLine(x);
            return x;
        }
        public static Time Now()
        {
            DateTime time = DateTime.Now;
            Time time2 = new Time(time.Hour, time.Minute, time.Second, time.Day, time.Month, time.Year);
            time2.ToString();
            return time2;

        }

    }
}
