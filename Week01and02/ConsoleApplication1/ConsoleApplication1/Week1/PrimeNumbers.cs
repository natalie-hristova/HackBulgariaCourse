using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrimeNumbers
    {
        public static bool IsPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            return isPrime;
        }
        public static void ListFirstPrimes(int n)
        {

            int[] firstNPrimes = new int[n];

            int x = 0;
           
                for (int i = 1; i < n * n; i++)
                {
                    if (IsPrime(i) == true && x<n)
                    {
                        firstNPrimes[x] = i;
                        x++;
                        Console.Write(firstNPrimes[x] + "  ");
                    }

                }
            }
        }

    }



