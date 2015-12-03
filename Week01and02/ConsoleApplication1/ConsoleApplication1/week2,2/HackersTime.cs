using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{ 
    class HackersTime
    {
        public static void HackerTime() {
       
            DateTime now = DateTime.Now;
            DateTime hacTime = new DateTime(now.Year,12,21,13,37,0);
            if (now > hacTime) {
                hacTime = hacTime.AddYears(1);
            }
            
            TimeSpan remaining = new TimeSpan();
            remaining = hacTime - now;
            Console.WriteLine("{0:dd\\hh\\mm}", remaining);
        }
    }
}
