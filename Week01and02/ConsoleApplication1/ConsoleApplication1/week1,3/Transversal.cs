using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Transversal
    {
        static int br = 0;
        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
           
            bool x = false;
            var fam = family.ToArray();
            if (fam.Length != transversal.Count)
            {
                x = false;
            }
            else
            {
                for (int i = 0; i < transversal.Count; i++)
                {
                    for (int j = 0; j < fam.Length; j++)
                    {
                        for (int k = 0; k < fam[j].Count; k++)
                        {
                            if (transversal[i].Equals(fam[j].ElementAt(k))){
                                br++;
                                transversal[i] = -1;
                                Console.WriteLine(br);    
                            }
                        }
                       
                    }
                }
                if (br == transversal.Count)
                    x = true;
            }
            return x;
        }
    }
}
