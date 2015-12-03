using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HackNumbers
    {
        public static bool IsHack(int n)
        {
            bool isHackNumber = true;
            int br = 0,br1=0;
            string binary = Convert.ToString(n, 2);

            for(int j = 0; j < binary.Length; j++)
            {
                if (binary[j] == '1') {

                    br++;
               
                }

            }
           
            br1 = br % 2;
            for (int i = 0; i < binary.Length / 2; i++)
            {
                if (!binary[i].Equals(binary[binary.Length - 1 - i]))
                {
                    isHackNumber = false;
                    break;
                }
            }
            return (isHackNumber && br1==1);
        }


        public static int NextHack(int n)
        {

            int bigger = n + 1;
            while (IsHack(bigger) == false)
            {
                bigger++;
            }

            return bigger;
        }
    }
}

