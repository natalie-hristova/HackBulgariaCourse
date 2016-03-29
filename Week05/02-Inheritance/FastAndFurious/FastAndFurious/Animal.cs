using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    abstract class Animal
    {
        protected abstract void Move();
        protected abstract void Eat();
        protected abstract void GiveBirth();
    }

    class Mammals : Animal
    {
        protected override void Move()
        {
            Console.WriteLine(" Moving paws.");
        }
        protected override void Eat()
        {
            Console.WriteLine("Eating Banana!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Need Mik");
        }
        public virtual void  Greed()
        {
            Console.WriteLine("Make sound ");
        }

    }
    class Reptiles : Animal
    {
        protected override void Move()
        {
            Console.WriteLine(" Slowly Crowing.");
        }
        protected override void Eat()
        {
            Console.WriteLine("puke!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Eggs");
        }
        public virtual void Greed()
        {
            Console.WriteLine("Rrr ");
        }
        public  virtual void Temperature(double temp) {
            Console.WriteLine("The temperature of the reptile is :{0}",temp);
        }
    }
    class Fish : Animal
    {
        protected override void Move()
        {
            Console.WriteLine("Just Swim.");
        }
        protected override void Eat()
        {
            Console.WriteLine("warmssss!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Haiver");
        }

    }
    class Birds : Animal
    {
        protected override void Move()
        {
            Console.WriteLine("Flyyyyy!");
        }
        protected override void Eat()
        {
            Console.WriteLine("Nibble!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Little birds");
        }
        public virtual void Greed()
        {
    
        Console.WriteLine("Sing! ");
        }
        public virtual void MakeNest() {
            Console.WriteLine("Making nest!");
        }
    }

    class Cat : Mammals
    {
        protected override void Move()
        {
            Console.WriteLine(" Moving kitty  paws.");
        }
        protected override void Eat()
        {
            Console.WriteLine("Eating meat!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Kitty is giving birth");
        }
        public override void Greed()
        {
            Console.WriteLine("Meow!");
        }
    }
    class Dog : Mammals
    {
        protected override void Move()
        {
            Console.WriteLine(" Moving dog  paws.");
        }
        protected override void Eat()
        {
            Console.WriteLine("Eating bone!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Dog is giving birth");
        }
        public override void Greed()
        {
            Console.WriteLine("Bau Bau!");
        }
    }
    class Crocodile : Reptiles
    {
        protected override void Move()
        {
            Console.WriteLine(" Slowly Crowing.(crocodile)");
        }
        protected override void Eat()
        {
            Console.WriteLine("Moving Jaws !");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Crocodile Eggs");
        }
        public override void Greed()
        {
            Console.WriteLine("Rrr crocodile ");
        }
        public override void Temperature(double temp)
        {
            Console.WriteLine("The temperature of the crocodile is :{0}", temp);
        }
    }
    class Owl : Birds
    {
        protected override void Move()
        {
            Console.WriteLine("Fly slowly!");
        }
        protected override void Eat()
        {
            Console.WriteLine("Nibble slowlyy!");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Little owls");
        }
        public override void Greed()
        {

            Console.WriteLine("Buhu Buhu! ");
        }
        public override void MakeNest()
        {
            Console.WriteLine("Making  owl nest!");
        }
    }
    class Shark : Fish
    {
        protected override void Move()
        {
            Console.WriteLine(" Swim.");
        }
        protected override void Eat()
        {
            Console.WriteLine("Blood !");
        }
        protected override void GiveBirth()
        {
            Console.WriteLine("Little Sharks ");
        }

    }

}

