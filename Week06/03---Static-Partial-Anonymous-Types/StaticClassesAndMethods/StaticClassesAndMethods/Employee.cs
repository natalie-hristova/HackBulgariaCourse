using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    public partial class Employee
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public decimal Salary { set; get; }
        //public string Position { set; get; }
        public decimal Taxes { set; get; }
        public decimal Bonus { set; get; }
        partial void Print();
    }
}
