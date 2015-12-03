using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DecodeURL
    {
        public static string DecodeUrl(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb.ToString().Contains("%20"))
                 sb.Replace("%20", " ");
                else if (sb.ToString().Contains("%3A"))
                    sb.Replace("%3A", ":");
                else if (sb.ToString().Contains("%3D"))
                    sb.Replace("%3D", "?");
                else if (sb.ToString().Contains("%2F"))
                    sb.Replace("%2F", "/");
            }

            return sb.ToString();
        }

    }
}
