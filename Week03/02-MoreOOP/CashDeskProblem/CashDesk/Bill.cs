using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill
    {
        public int amount;
        public Bill(int amount)
        {
            this.amount = amount;
        }

        public int Amount
        {
            get;
            set;
        }

        public override string ToString()
        {
            string a = string.Format("A {0}$ bill", amount);
            return a;
        }
        public static bool operator ==(Bill a, Bill b)
        {

            return (a.amount == b.amount);
        }
        public static bool operator !=(Bill a, Bill b)
        {
            return !(a.amount == b.amount);
        }
        public int Value()
        {
            return amount;
        }
        public static explicit operator int (Bill b)
        {

            return b.amount;
        }

    }
}
