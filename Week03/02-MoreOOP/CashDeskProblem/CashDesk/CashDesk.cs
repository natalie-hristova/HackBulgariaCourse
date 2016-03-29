using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
  public  class CashDesk
    {
        public Dictionary<int, int> billCashDesk = new Dictionary<int, int>();
        //0-1 1-2 2-5 3-10 4-20 5-50 6-100

        public void TakeMoney(Bill bill)
        {
            if (billCashDesk.ContainsKey(bill.amount))
                billCashDesk[bill.amount]++;
            else
                billCashDesk.Add(bill.amount, 1);
           
        }

        public void TakeMoney(BatchBill batchBill)
        {
            foreach (Bill bill in batchBill)
            {
                if (billCashDesk.ContainsKey(bill.amount))
                    billCashDesk[bill.amount]++;
                else
                    billCashDesk.Add(bill.amount, 1);
            }
        }
        public int  Total() {
            int sum = 0;
            foreach (var bill in billCashDesk)
            {
                sum += bill.Key * bill.Value;
            }
           // Console.WriteLine(sum);
            return sum;
        }
        public void Inspect() {
            foreach (var bill in billCashDesk)
            {
                Console.WriteLine("The banknotes of {0} $ are {1}", bill.Key, bill.Value);
            }
        }
    }
}
