using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fractions
    {
        private int wholePart = 1;
        private float part = 1.00f;

        public Fractions(int numerator, int denominator)
        {
            wholePart = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0");
            }
            else
                while (part >= 1)
                {
                    part = (float)denominator / 10;
                }
        }

        public int WholePart
        {
            get;
            set;

        }

        public float Part
        {
            get
            {
                return part;
            }
            set
            {
                if (value != 0)
                    part = value;
            }
        }

        public override string ToString()
        {
            part = WholePart / part;
            string x = part.ToString();
            Console.WriteLine(x);
            return x;
        }

        public override bool Equals(System.Object obj)
        {
            Fractions obj1 = new Fractions(1, 2);
            if (this.wholePart != obj1.wholePart)
                return false;
            else if (this.part != obj1.part)
                return false;
            else return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + wholePart.GetHashCode();
                hash = hash * 23 + part.GetHashCode();
                return hash;
            }
        }
        public static bool operator ==(Fractions p1, Fractions p2)
        {
            if (p1.wholePart.Equals(p2.wholePart))
                return true;
            else return false;
        }
        public static bool operator !=(Fractions p1, Fractions p2)
        {
            if (!p1.wholePart.Equals(p2.wholePart))
                return true;
            else return false;
        }
        public static Fractions operator +(Fractions p1, Fractions p2)
        {
            var x = new Fractions(0, 1);
            if (p1.part + p2.part < 1)
            {
                x.part = p1.part + p2.part;
                x.wholePart = p1.wholePart + p2.wholePart;
            }
            else
            {
                x.wholePart = p1.wholePart + p2.wholePart + 1;
                x.part = p1.part + p2.part - 1;
            }
            Console.WriteLine("Operator +++" + x.wholePart + "." + x.part);
            return x;
        }
        public static Fractions operator -(Fractions p1, Fractions p2)
        {
            var x = new Fractions(0, 1);
            if (p1.part >= p2.part)
            {
                x.part = p1.part - p2.part;
                x.wholePart = p1.wholePart - p2.wholePart;
            }
            else
            {
                x.part = (p1.part + 1) - p2.part;
                x.wholePart = p1.wholePart - p2.wholePart - 1;
            }
            Console.WriteLine("Operator ----" + x.wholePart + "." + x.part);
            return x;
        }
        public static double operator +(Fractions p1, double p2)
        {
            double c = p1.wholePart + p1.part + p2;
            Console.WriteLine("Operator +: double" + c);
            return c;
        }
        public static double operator -(Fractions p1, double p2)
        {
            double c = p1.wholePart + p1.part - p2;
            Console.WriteLine("Operator - :double" + c);
            return c;
        }
        public static double operator *(Fractions p1, double p2)
        {
            double c = (p1.wholePart + p1.part) * p2;
            Console.WriteLine("Operator *:double" + c);
            return c;
        }
        public static explicit operator double (Fractions p1)
        {
            double x = p1.part + p1.wholePart;
            return x;
        }
    }
}

