using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class Combination<T, U>
    {
        public readonly T tFirst; 
        public readonly T tSecond;
        public readonly T tThird;
        public readonly U uFirst;
        public readonly U uSecond;
        public readonly U uThird;


        public Combination(T tFirst, T tSecond, T tThird, U uFirst, U uSecond, U uThird)
        {
            this.tFirst = tFirst;
            this.tSecond = tSecond;
            this.tThird = tThird;
            this.uFirst = uFirst;
            this.uSecond = uSecond;
            this.uThird = uThird;

        }
        public Combination() {

        }
        public override bool Equals(System.Object comb)
        {
            Combination<T, U> combo = comb as Combination<T, U>;

            if (this.tFirst.Equals(combo.tFirst) && this.tSecond.Equals(combo.tSecond) && this.tThird.Equals(combo.tThird))
            {
                if (this.uFirst.Equals(combo.uFirst) && this.uSecond.Equals(combo.uSecond) && this.uThird.Equals(combo.uThird))
                    return true;
                else return false;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + tFirst.GetHashCode();
                hash = hash * 23 + tSecond.GetHashCode();
                hash = hash * 23 + tThird.GetHashCode();
                hash = hash * 23 + uFirst.GetHashCode();
                hash = hash * 23 + uSecond.GetHashCode();
                hash = hash * 23 + uThird.GetHashCode();
                return hash;
            }
        }
    }
}
