using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{

    public abstract class Shape:IMovable
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
        //????
        void IMovable.Move(double x, double y) { }
    }

    public class Rectangle : Shape, IMovable
    {
        public double Width { get; set; }
        public virtual double Height { get; set; }
        public Point Center { get; set; }
        public Rectangle(double width, double height, Point center)
        {
            this.Width = width;
            this.Height = height;
            this.Center = center;

        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return Width * 2 + Height * 2;
        }
        public override string ToString()
        {
            return string.Format("This rectangle hasc witdh:{0},height:{1} and center({2},{3})", Width, Height, Center.X, Center.Y);
        }
        void IMovable.Move(double x, double y)
        {
            Center.X += x;
            this.Center.Y += y;
}

    }

    public class Square : Rectangle,IMovable
    {
        double Side { get; set; }

        public Square(double side, Point center) : base(side, side, center)
        {
            this.Side = side;
        }

        public void ChangeSide(double side)
        {
            this.Side = side;
            this.Width = side;
            this.Height = side;
        }
        public override string ToString()
        {
            return string.Format("This sqare has side:{0} and center({1},{2})", Side, Center.X, Center.Y);
        }
        void IMovable.Move(double x ,double y) {
            this.Center.X += x;
            this.Center.Y += y;
        }
    }


    public class Ellipse : Shape,IMovable
    {
        public double RadiusX { get; set; }
        public double RadiusY { get; set; }
        public Point Center { get; set; }
        public Ellipse(double RadiusX, double RadiusY, Point center)
        {
            this.RadiusX = RadiusX;
            this.RadiusY = RadiusY;
            this.Center = center;
        }
        public override double GetArea()
        {
            return (RadiusX * RadiusY * 3.14);
        }
        public override double GetPerimeter()
        {

            return 3.14 * (1.5 * (RadiusX + RadiusY) - Math.Sqrt(RadiusX * RadiusY));
        }
        public override string ToString()
        {
            return string.Format("The ellipse has radius X:{0} ,radius Y:{1} and center ({2},{3})", RadiusX, RadiusY, Center.X, Center.Y);
        }
        void IMovable.Move(double x, double y) {
            this.Center.X += x;
            this.Center.Y += y;
        }
    }
    public class Circle : Ellipse,IMovable
    {
        double Radius { get; set; }

        public Circle(double radius, Point center) : base(radius, radius, center)
        {
            this.Radius = radius;
        }

        public void ChangeRadius(double radius)
        {
            this.Radius = radius;
            this.RadiusX = radius;
            this.RadiusY = radius;
        }
        public override string ToString()
        {
            return string.Format("The circle has radius:{0} and center ({1},{2})", Radius, Center.X, Center.Y);
        }
        void IMovable.Move(double x, double y) {
            this.Center.X += x;
            this.Center.Y += y;
        }
    }
  public  class Triangle : Shape
    {
        double Vertex1;
        double Vertex2;
        double Vertex3;

        public Triangle(double Vertex1, double Vertex2, double Vertex3)
        {
            this.Vertex1 = Vertex1;
            this.Vertex2 = Vertex2;
            this.Vertex3 = Vertex3;
        }
        public override double GetPerimeter()
        {
            double b = Vertex1 + Vertex2 + Vertex3;
            return (b);
        }
        public override double GetArea()
        {
            double p = GetPerimeter()/2;
            return Math.Sqrt(p * (p - Vertex1) * (p - Vertex2) * (p - Vertex3));
        }
        public override string ToString()
        {
            return string.Format("The triangle has sides a:{0}, b:{1} and c:{2}", Vertex1, Vertex2, Vertex3);
        }

    }
}
