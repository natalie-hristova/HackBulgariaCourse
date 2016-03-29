using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape;


namespace FastAndFurious
{
    class Program
    {
        static void Main(string[] args)
        {

            //Toy a = new Toy(color: "blue", size: 15);
            //Toy b = new Toy(12, "pink");
            //Toy c = new Toy(58, "green");
            //List<Toy> toys = new List<Toy> { a, b, c };
            //Person c1 = new Children(false);
            //Children c2 = new Children(false, toys);
            //Adults ad = new Adults(true);
            //List<Children> list = new List<Children>() { (Children)c1, c2 };
            //Adults ad2 = new Adults(true, list);
            //Console.WriteLine(ad2.ToString());
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            // Console.WriteLine(a.ToString());
            Point a = new Point(2, 2);
            Rectangle b = new Rectangle(3,2,a);
            Square d = new Square(2,a);
            Rectangle c = new Square(3,a);
            Ellipse e = new Ellipse(3, 2, a);
            Circle f = new Circle(3, a);
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(t.ToString());
            Console.WriteLine(t.GetArea());
            Console.WriteLine(t.GetPerimeter());
            IMovable x = new Square(2,a);
            Console.WriteLine(x.ToString());
            x.Move(3, 3);
            Console.WriteLine(x.ToString());
            
        }
    }
}
