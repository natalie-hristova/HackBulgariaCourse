using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Point : IMovable

    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("The Point's x:{0},y:{1}", X, Y);
        }

        void IMovable.Move(double x, double y)
        {
            this.X += x;
            this.Y += y;
        }
    }
}
