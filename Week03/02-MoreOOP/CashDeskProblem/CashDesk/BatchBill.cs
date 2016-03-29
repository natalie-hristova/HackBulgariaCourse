using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill
    {
        List<Bill> batch;

        public BatchBill(List<Bill> batch)
        {
            this.batch = batch;
        }

        public int[] Count()
        {
            int x = this.batch.Count;
            int[] array = new int[7];
            int br1 = 0, br2 = 0, br5 = 0, br10 = 0, br20 = 0, br50 = 0, br100 = 0;
            for (int i = 0; i < x; i++)
            {
                if (this.batch[i].amount == 1) br1++;
                else if (this.batch[i].amount == 2) br2++;
                else if (this.batch[i].amount == 5) br5++;
                else if (this.batch[i].amount == 10) br10++;
                else if (this.batch[i].amount == 20) br20++;
                else if (this.batch[i].amount == 50) br50++;
                else if (this.batch[i].amount == 100) br100++;
            }
            array[0] = br1;
            array[1] = br2;
            array[2] = br5;
            array[3] = br10;
            array[4] = br20;
            array[5] = br50;
            array[6] = br100;
            Console.WriteLine("1lv:{0},2lv:{1},5lv:{2},10lv:{3},20lv:{4},1lv:{5},50lv:{0},100lv:{6}",
              array[0], array[1], array[2], array[3], array[4], array[5], array[6]);
            return array;
        }
        public int Total()
        {
            int sum = 0;

            for (int i = 0; i < this.batch.Count; i++)
            {
                sum += this.batch[i].amount;
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.batch.Count; i++)
            {
                //Console.WriteLine(batch.ElementAt(i).ToString());
                sb.Append(batch.ElementAt(i).ToString() + "  ");

            }
            return sb.ToString();
        }

        public IEnumerator GetEnumerator() {
            return batch.GetEnumerator();
        }
    }


}
