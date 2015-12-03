using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LineSegment
    {
       private  Point start;
        private Point end;

        public LineSegment(Point start, Point end) {
            if (start.Equals(end))
                throw new ArgumentException("Cannot create a line segment with zero length");
            else {
                this.start = start;
                this.end = end;
            }
        }
            public Point Start {
            get {
                Console.WriteLine(start);
                return start;
            }
        }

        public Point End
        {
            get
            {
                Console.WriteLine(end);
                return start;
            }
        }

        public  double GetLength() {
            
            double length = Math.Pow((Start.X - End.X), 2) + Math.Pow((Start.Y - End.Y), 2);
            return Math.Sqrt(length);
        }
        public override string ToString()
        {
           
            string line = string.Format("Line[{0}, {1}], ({2}, {3})]",start.X, start.Y,end.X,end.Y);
            return line;
        }
    }
    }

