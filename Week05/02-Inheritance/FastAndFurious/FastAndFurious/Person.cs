using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    abstract class Person
    {
        protected bool IsWoman { get; private set; }

        public Person(bool IsWoman)
        {
            this.IsWoman = IsWoman;
        }
        protected abstract void DailyStuff();
        
    }

    class Children : Person
    {
        List<Toy> toys;
        public Children(bool x) : base(x) { }
        public Children(bool x, List<Toy> toys) : base(x)
        {
            this.toys = toys;
        }
        protected override void DailyStuff()
        {
            Console.WriteLine("Play");
        }
        public  override string ToString()
        {
            string a;
            if (toys!= null)
            {
                a = string.Format("The child  gender is  female :{0}  and has {1} toys.",
                IsWoman, toys.Count);
            }else 
                a = string.Format("The child  gender is  female :{0}  and has no toys.",
                IsWoman);


            return a;
        }
    }
    class Adults : Person
    {
        List<Children> children;
        bool IsBoring { get; set; }
        public Adults(bool sex) : base(sex) { }
        public Adults(bool sex, List<Children> children) : base(sex)
        {
            this.children = children;
        }
        protected override void DailyStuff()
        {
            Console.WriteLine("Go to work!");
        }
        public  override string ToString()
        {
            string a;
            if (children!= null)
            {
                a = string.Format("The adult  gender is  female :{0}  and has {1} children.",
                IsWoman, children.Count);
            }
          else
                a = string.Format("The adult  gender is  female :{0}  and has no children.",
                IsWoman);

            return a;
        }
    }
    class Toy
    {
        double size;
        string color;

        public Toy(double size, string color)
        {
            this.size = size;
            this.color = color;
        }
        public override string ToString()
        {
            return string.Format("The toy is {0} and is {1} cm. large.",color,size);
        }
    }

}
