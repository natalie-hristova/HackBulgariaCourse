using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {

        private Point start;
        private Point end;

        public LineSegment(Point start, Point end)
        {
            if (start.Equals(end))
                throw new ArgumentException("Cannot create a line segment with zero length");
            else
            {
                this.start = start;
                this.end = end;
            }
        }
        public Point Start
        {
            get
            {
                //  Console.WriteLine(start);
                return start;
            }
        }

        public Point End
        {
            get
            {
                //   Console.WriteLine(end);
                return end;
            }
        }

        public double GetLength()
        {

            double length = Math.Pow((start.X - end.X), 2) + Math.Pow((start.Y - end.Y), 2);
            return Math.Sqrt(length);
        }
        public override string ToString()
        {
            string line = string.Format("Line[{0}, {1}], ({2}, {3})]", start.X, start.Y, end.X, end.Y);
            return line;
        }
        public override bool Equals(System.Object obj)
        {
            LineSegment a = obj as LineSegment;

            return (a.start.X == this.start.X && a.start.Y == this.start.Y &&
                a.end.X == this.end.X && a.end.Y == this.end.Y);
        }

        public static bool operator ==(LineSegment a, LineSegment b)
        {
            if (a.GetLength() == b.GetLength())
                return true;
            else return false;
        }

        public static bool operator !=(LineSegment a, LineSegment b)
        {
            if (a.GetLength() == b.GetLength())
                return false;
            else return true;
        }
        public static bool operator >(LineSegment a, LineSegment b)
        {
            return (a.GetLength() > b.GetLength());
        }
        public static bool operator <(LineSegment a, LineSegment b)
        {
            return (a.GetLength() < b.GetLength());
        }
        public static bool operator <=(LineSegment a, LineSegment b)
        {
            return (a.GetLength() <= b.GetLength());
        }
        public static bool operator >=(LineSegment a, LineSegment b)
        {
            return (a.GetLength() >= b.GetLength());
        }
        public static bool operator >(LineSegment a, float b)
        {
            return (a.GetLength() > b);
        }
        public static bool operator <(LineSegment a, float b)
        {
            return (a.GetLength() < b);
        }
        public static bool operator <=(LineSegment a, float b)
        {
            return (a.GetLength() <= b);
        }
        public static bool operator >=(LineSegment a, float b)
        {
            return (a.GetLength() >= b);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + start.GetHashCode();
                hash = hash * 23 + end.GetHashCode();
                return hash;
            }
        }
    }
}

