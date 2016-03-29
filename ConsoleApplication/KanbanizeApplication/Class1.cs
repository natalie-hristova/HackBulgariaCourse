using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcApplication
{
    class Class1
    {
        StringBuilder list = new StringBuilder();
        public Class1()
        {
            string b = "Does not matter";
            while (!b.Equals(""))
            {
                Console.WriteLine("Enter the string:");
                b = Console.ReadLine();
                this.list.Append(b);
            }
        }

        public void FullTheNumberList()
        {
            List<int> numbers = new List<int>();
            int temp;
            for (int i = 0; i < list.Length; i++)
            {
                if (int.TryParse(list[i].ToString(), out temp))
                {
                    numbers.Add(int.Parse(list[i].ToString()));
                }
            }
            if (numbers.Count != 0)
            {
                WantedNumbers(numbers);

            }
            else
                Console.WriteLine("No numbers were set!");
        }

        public void WantedNumbers(List<int> numbersList)
        {
            int min = numbersList.Min();
            int max = numbersList.Max();
            Console.WriteLine("Min: " + min + "\nMax: " + max);
            if (min == max || min + 1 == max)
                Console.WriteLine("There is now a number between the Min:{0} and the Max:{1}!",min,max);
            else
            {
                for (int i = min + 1; i < max; i++)
                {
                    Console.Write("{0},", i);
                }
                Console.WriteLine();
            }
        }
    }

}

