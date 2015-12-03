using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pair
    {
        //readonly dastane immutable ama mai ne se pishe taka
      private  Time obj1;
       private Time obj2;

        public Pair(Time obj1, Time obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }

        public Time Obj1 {
            get;
            set;
        }

        public Time Obj2
        {
            get;
            set;
        }

        public static bool operator ==(Pair p1, Pair p2)
        {
            if (p1.obj1.ToString().Equals(p2.obj1.ToString()) &&
                p1.obj2.ToString().Equals(p2.obj2.ToString()))
                return true;
            else return false;
        }
        public static bool operator !=(Pair p1, Pair p2)
        {
            if (!p1.obj1.ToString().Equals(p2.obj1.ToString()) ||
                !p1.obj2.ToString().Equals(p2.obj2.ToString()))
                return true;
            else return false;
        }
         
        public override string ToString()
        {
            string x= string.Format("{0}:{1}:{2} {3}.{4}.{5}", this.obj1.hour, this.obj1.min,
                this.obj1.sec, this.obj1.day, this.obj1.month, this.obj1.year);
            string y= string.Format(" {0}:{1}:{2} {3}.{4}.{5}", this.obj2.hour, this.obj2.min,
                this.obj2.sec, this.obj2.day, this.obj2.month, this.obj2.year);
            return x + y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + obj1.GetHashCode();
                hash = hash * 23 + obj2.GetHashCode();
                return hash;
            }
        }
            public override bool Equals(System.Object obj)
        {
            Pair a = obj as Pair;
            return (this.obj1.ToString().Equals(a.obj1.ToString()) &&
               this.obj2.ToString().Equals(a.obj2.ToString()));
            
        }
    }
    }

