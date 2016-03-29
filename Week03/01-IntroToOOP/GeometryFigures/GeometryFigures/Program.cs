using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Point p3 = new Point(7, 7);
            Point p4 = new Point(0, 0);
            //Console.WriteLine(p1.Equals(p2));
            //p1.Equals(p2);

            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1.Equals(p3));
            //Console.WriteLine(p1 != p2);
            //Console.WriteLine(p1 != p3);
         
            //// LineSegment ls3 = new LineSegment(p1, p1);
            //Console.WriteLine(ls1.GetLength());
            //Console.WriteLine(ls1.ToString());
            //Console.WriteLine(ls2.Equals(ls1));
            //Console.WriteLine(ls1 == ls2);
            //Console.WriteLine(ls1 != ls2);
            //Console.WriteLine(ls1 >= 5.00f);
            //Console.WriteLine(ls1 <= 4.00f);
            Point p1 = new Point();
            Point p2 = new Point(4, 4);
            Rectangle a = new Rectangle(p1,p2);
            Console.WriteLine(a.GetArea());
            Console.WriteLine(a.GetPerimeter());
            Console.WriteLine(a.Down + " " + a.Center + " " + a.Up + " " + a.Left + " " +a.Right);
        }
    }
}
