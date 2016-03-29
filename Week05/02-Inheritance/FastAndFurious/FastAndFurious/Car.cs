using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    public abstract class Car
    {

        protected abstract bool IsEcoFriendly(bool testing);
    }

    class Audi : Car
    {
        protected override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
        private double GetMileage(double mileague) {
            return mileague;
        }
    }


    class BMW : Car
    {
        protected override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
        private double GetMileage(double mileague)
        {
            return mileague;
        }
    }
    class Volkswagen : Car
    {
        protected override bool IsEcoFriendly(bool testing)
        {
            return testing;
        }
        private double GetMileage(double mileague)
        {
            return mileague;
        }
    }
    class Honda : Car
    {
        protected override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
    class Skoda : Car
    {
        protected override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
