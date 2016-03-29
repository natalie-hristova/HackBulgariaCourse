using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Time time2 = new Time(13, 45, 45, 12, 12, 2015);
            ////time2.ToString();
            ////Time.Now();
            //Time time1 = new Time(13, 45, 45, 12, 12, 2015);
            //Time time3 = new Time(15, 45, 45, 12, 12, 2015);
            //Pair pair = new Pair(time1, time3);
            //Pair pair2 = new Pair(time1, time2);
            //bool s = (pair == pair2);
            //Console.WriteLine(s);
            //Console.WriteLine(pair.Equals(pair2));

            Fractions s = new Fractions(10, 6);
            Fractions s2 = new Fractions(5, 3);
            Fractions s3 = new Fractions(7, 3);
            s.ToString();
            Console.WriteLine(s.GetHashCode());
            bool x = s == s2;
            bool x1 = s == s3;
            Console.WriteLine(x + "    " + x1);
            bool a = s != s2;
            bool a1 = s != s3;
            Console.WriteLine(a + "    " + a1);
            Fractions p = new Fractions(3, 3);
            double w;
            double r = 10.5;
            w = s + r;
            w = s - r;
            s.Equals(s2);
        }
    }
}
