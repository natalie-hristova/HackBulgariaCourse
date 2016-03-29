using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Fractions
    {
        private int numerator;
        private int denominator;

        public Fractions(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0");
            }
            else
                this.denominator = denominator;
        }

        public int Numerator
        {
            get;
            set;

        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value != 0)
                    this.denominator = value;
            }
        }

        public override string ToString()
        {
            float part = (float)numerator / (float)denominator;
            string x = part.ToString();
            Console.WriteLine(x);
            return x;
        }

        public override bool Equals(System.Object obj)
        {
            Fractions a = obj as Fractions;
            return ((this.numerator == a.numerator) && (this.denominator == a.denominator));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }
        public static bool operator ==(Fractions p1, Fractions p2)
        {
            Fractions a = Fractions.Simple(p1);
            Fractions b = Fractions.Simple(p2);
            if (((float)a.numerator / a.denominator) / ((float)b.numerator / b.denominator) > 1 || ((float)a.numerator / a.denominator) / ((float)b.numerator / b.denominator) < 1)
                return false;
            else return true;
        }
        public static bool operator !=(Fractions p1, Fractions p2)
        {
            Fractions a = Fractions.Simple(p1);
            Fractions b = Fractions.Simple(p2);
            if (a == b)
                return false;
            else return true;
        }
        public static Fractions operator +(Fractions p1, Fractions p2)
        {
            int fden = p1.denominator;
            int sden = p2.numerator;
            p1.numerator *= sden;
            p1.denominator *= sden;
            p2.denominator *= fden;
            p2.numerator *= fden;
            Fractions a = new Fractions(1, 2);
            a.numerator = p1.numerator + p2.numerator;
            a.denominator = p2.denominator;
            Fractions.Simple(a);
            Console.WriteLine("Operator +++" + a);
            return a;
        }
        public static Fractions operator -(Fractions p1, Fractions p2)
        {
            int fden = p1.denominator;
            int sden = p2.numerator;

            p1.numerator *= sden;
            p1.denominator *= sden;
            p2.denominator *= fden;
            p2.numerator *= fden;
            Fractions a = new Fractions(1, 2);
            a.numerator = p1.numerator - p2.numerator;
            a.denominator = p2.denominator;
            Fractions.Simple(a);
            Console.WriteLine("Operator ---" + a);

            return a;
        }
        public static double operator +(Fractions p1, double p2)
        {

            double c = ((double)p1.numerator / p1.denominator + p2);

            Console.WriteLine("Operator +: double" + c);
            return c;
        }
        public static double operator -(Fractions p1, double p2)
        {
            double c = (double)p1.numerator / p1.denominator - p2;
            Console.WriteLine("Operator - :double" + c);
            return c;
        }
        public static double operator *(Fractions p1, double p2)
        {
            double c = ((double)p1.numerator / p1.denominator) * p2;
            Console.WriteLine("Operator *:double" + c);
            return c;
        }
        public static explicit operator double (Fractions p1)
        {
            double x = (double)p1.numerator / p1.denominator;
            return x;
        }


        public static Fractions Simple(Fractions a)
        {
            if (a.denominator >= a.numerator)
            {
                for (int i = a.denominator; i > 0; i--)
                {
                    if (a.numerator % i == 0)
                    {
                        a.denominator = a.denominator / i;
                        a.numerator = a.numerator / i;
                    }
                }
            }
            else
                for (int i = a.numerator; i > 0; i--)
                {
                    if (a.denominator % i == 0)
                    {
                        a.denominator = a.denominator / i;
                        a.numerator = a.numerator / i;
                    }
                }
            return a;
        }
    }
}

