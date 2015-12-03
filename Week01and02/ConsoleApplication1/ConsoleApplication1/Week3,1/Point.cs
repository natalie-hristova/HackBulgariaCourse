using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public double X {
            get {
                Console.WriteLine("The x:{0}",x);
                return x;
            }
        }

        public double Y {
            get {
                Console.WriteLine("The y:{0}", x);
                return y;
            }
        }

        public override string ToString()
        {
            string a = string.Format(" Point({0},{1})", x, y);
            Console.WriteLine(a);
            return a;
        }
        public override bool Equals(System.Object obj)
        {
            Point a= obj as Point;
            return ((this.x == a.x) && (this.y == a.y));
            
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
        public static  bool operator ==(Point a,Point b) {
            if (a.x.Equals(b.x) && a.y.Equals(b.y))
                return true;
            else return false;

        }
        public static bool operator !=(Point a, Point b) {
            if (!a.x.Equals(b.x) || !a.y.Equals(b.y))
                return true;
            else return false;
        
        }
        
    }
}
