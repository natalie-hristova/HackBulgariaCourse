using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAgregatorApplication
{
    class AverageAgragator
    {
        List<int> Numbers = new List<int>();
        public event EventHandler AverageChanged;

        public decimal Average { private set; get; }


        public void AddNumber(int number)
        {
            if (Numbers.Count != 0)
            {
                foreach (var item in Numbers)
                    Average += item;
                Average = Average / (Numbers.Count + 1);
            }
            else
                Average = 0;

            Numbers.Add(number);
            decimal newAverage = 0;
            foreach (var item in Numbers)
                newAverage += item;
            newAverage = newAverage / Numbers.Count;

            if (Average != newAverage)
            {
                Average = newAverage;
                if (AverageChanged != null)
                    AverageChanged(this, new EventArgs());
            }
        }
    }
}
