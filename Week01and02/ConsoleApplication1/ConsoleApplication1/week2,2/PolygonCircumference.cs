using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PolygonCircumference
    {
        public static float CalcCircumference(PointF[] points)
        {
            float P = 0;

            int type = points.Count();
            for (int i = 0; i < type - 1; i++)
            {
                P += sideLength(points[i], points[i + 1]);
            }
            P += sideLength(points[0], points[type - 1]);
            Console.WriteLine(P);
            return P;
        }
        public static float sideLength(PointF a, PointF b)
        {
            float c;
            float x = a.X - b.X;
            float y = a.Y - b.Y;
            c = (float)Math.Pow(x, 2) + (float)Math.Pow(y, 2);
            return (float)Math.Sqrt(c);
        }


        public static float CalcArea(PointF[] points)
        {
            float S = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                S += points[i].X * points[i + 1].Y - points[i].Y * points[i + 1].X;
            }
            Console.WriteLine(S / 2.0f);
            return S / 2.0f;
        }

    }
}
