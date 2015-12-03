using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    class InflateRectangle
    {
        public static void Inflate(ref Rectangle rect, System.Drawing.Size inflateSize)
        {
            int x = rect.X - inflateSize.Width;
            int y = rect.Y - inflateSize.Height;
            int width = rect.Width + inflateSize.Width*2;
            int height = rect.Height + inflateSize.Height*2;
            Console.WriteLine("x:{0},y:{1},w:{2},h:{3}", x, y, width, height);
        }
    }
}
