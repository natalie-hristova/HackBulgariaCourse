using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class LottoGame<T, U>
    {
        Combination<T, U> combo;
        public static List<Combination<int, string>> list = new List<Combination<int, string>>();

        public LottoGame(Combination<T, U> combo)
        {
            this.combo = combo;
        }

        public static void PlayersCombination()
        {
            Console.WriteLine("Enter the number of  combinations you want to enter:");
            string numberAsString = Console.ReadLine();
            //  Combination<int, string> winningCombo = new Combination<int, string>(1, 2, 3, "a", "b", "c");
            int n = int.Parse(numberAsString);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Next combo is :");
                string a = Console.ReadLine();
                string[] array;
                array = a.Split(' ');
                list.Add(new Combination<int, string>(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]),
                   array[3], array[4], array[5]));
                Console.WriteLine(list[i]);
                for (int j = 0; j < i; j++)
                {
                    if (list[i].Equals(list[j]))
                        Console.WriteLine("You have already made  this combination!");
                }
            }
            AnotherCombo();
        }
        public static void AddUserCombination()
        {
            Console.WriteLine("Enter the new combo");
            string a = Console.ReadLine();
            string[] array;
            array = a.Split(' ');
            list.Add(new Combination<int, string>(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]),
               array[3], array[4], array[5]));
            AnotherCombo();
        }

        public static void AnotherCombo()
        {
            Console.WriteLine("Would you like to  enter another combo ?");
            string anotherCombo = Console.ReadLine();
            if (anotherCombo.Equals("yes"))
            {
                AddUserCombination();
            }
            else
                Console.WriteLine("nee");
        }

    }
}
