using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClockAngle
    {
        public static int GetClockHandsAngle(DateTime time)
        {

            int min = time.Minute;
            int hour = time.Hour;
            if (min > 59 || hour > 23)
            {
                return 0;
            }
            else
            {
                if (hour > 12)
                {
                    hour = hour - 12;
                }
                int minagle = 6 * min;
                int hangle = 30 * hour;
                int x = minagle - hangle;

                if (x > 180)
                {
                    x = 360 - x;
                }
                else if (x < 0 && x > -180)
                {
                    x = -x;
                }
                else if (x < -180)
                    x = 360 + x;
                return x;
            }

        }
        public static int GetClockHandsAngle2(DateTime time)
        {

            int min = time.Minute;
            int hour = time.Hour;
            if (min > 59 || hour > 23)
            {
                return 0;
            }
            else
            {
                if (hour > 12)
                {
                    hour = hour - 12;
                }
                int minagle = 6 * min;
                int hangle = 30 * hour + min / 12;

                int x = minagle - hangle;

                if (x > 180)
                {
                    x = 360 - x;
                }
                else if (x < 0 && x > -180)
                {
                    x = -x;
                }
                else if (x < -180)
                    x = 360 + x;
                return x;
            }

        }
    }
}


