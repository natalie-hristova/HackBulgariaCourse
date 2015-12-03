using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DirectoryTraversal
    {
        public static IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            
            FileInfo[] fileInfo = dir.GetFiles("*",SearchOption.AllDirectories);
            DirectoryInfo[] directories = dir.GetDirectories("*", SearchOption.AllDirectories);
           
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(directories[i]);
               
            }
            for (int j = 0; j < fileInfo.Length; j++)
            {
                Console.WriteLine(fileInfo[j]);
            }
            yield return fileInfo.ToString();
        }

    }
}
