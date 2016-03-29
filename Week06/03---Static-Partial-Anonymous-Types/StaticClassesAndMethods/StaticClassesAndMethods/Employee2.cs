using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    public partial class Employee
    {

        partial void Print()
        {
            Console.WriteLine(FirstName + "  " + LastName);
        }

        public decimal CalculateAllIncome()
        {
            Console.WriteLine("The income is :{0}", Salary + Bonus);
            return (Salary + Bonus);
        }
        public decimal CalculateBalance()
        {
            Console.WriteLine("The balance is : {0}", Salary + Bonus - Taxes);
            return Salary + Bonus - Taxes;
        }
        public void Print2() {
           this.Print();
        }
    }
}
