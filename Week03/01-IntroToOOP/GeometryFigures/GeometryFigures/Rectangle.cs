using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        readonly private Point vert1;
        readonly private Point vert2;
        readonly private Point vert3;
        readonly private Point vert4;


        public Rectangle(Point vert1, Point vert2)
        {
            if (vert1.Equals(vert2))
                throw new ArgumentException("Cannot create a rectangle with zero length");
            else
            {
                this.vert1 = vert1;
                this.vert2 = vert2;
                this.vert3 = new Point(vert1.X, vert2.Y);
                this.vert4 = new Point(vert2.X, vert1.Y);

            }
        }
        public Rectangle(Rectangle rec)
        {
            Rectangle rec1 = new Rectangle(rec.vert1, rec.vert2);
        }

        public Point Vert1
        {
            get;
        }
        public Point Vert2
        {
            get;
        }

        public Point Vert3
        {
            get;
        }

        public Point Vert4
        {
            get;
        }

        public LineSegment Up
        {
            get {
                LineSegment up = new LineSegment(vert2, vert3);
                Console.WriteLine("Up:{0}",up);
                return up;
            }
        }

        public LineSegment Down
        {
            get
            {
                LineSegment down = new LineSegment(vert1, vert4);
                Console.WriteLine("Down:{0}", down);
                return down;
            }
        }
        public LineSegment Left
        {
            get
            {
                LineSegment left = new LineSegment(vert1, vert3);
                Console.WriteLine("Left:{0}", left);
                return left;
            }
        }
        public LineSegment Right
        {
            get
            {
                LineSegment right = new LineSegment(vert2, vert4);
                Console.WriteLine("Right:{0}", right);
                return right;
            }
        }
        public double Width {
            get {
                return Down.GetLength();
            }
        }
        public double Height
        {
            get
            {
                return Left.GetLength();
            }
        }
        public Point Center
        {
            get{
                Point c = new Point((double)(vert4.X - vert1.X)/2, (double)(vert3.Y - vert4.Y));
                return c;
            }
        }
        public double GetPerimeter() {
            return 2*((double)this.Up.GetLength() + this.Right.GetLength());
        }
        public double GetArea()
        {
            return ((double)this.Up.GetLength() * this.Left.GetLength());
        }
        public override string ToString()
        {
            string reci = string.Format("Rectangle[(({0}{1}), {2}{3}), {4}, {5})]",
                Vert1.X,vert1.Y,vert2.X,vert2.Y,Height,Width);
            return reci; 
        }

        public override bool Equals(System.Object obj)
        {
            Rectangle a = obj as Rectangle;
            return ((this.vert1 == a.vert1) && (this.vert2 == a.vert2));

        }
        public static bool operator ==(Rectangle a, Rectangle b)
        {
            return (a.Equals(b));
        }
        public static bool operator !=(Rectangle a, Rectangle b)
        {
            return (!a.Equals(b));

        }
        public override int GetHashCode()
        {
            int hash = 17;
                hash = hash * 23 + vert1.GetHashCode();
                hash = hash * 23 + vert2.GetHashCode();
                return hash;
        }
    }
}

