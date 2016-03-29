using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.GetReplacingValue();
            Employee employee = new Employee();
            employee.FirstName = "Natalie";
            employee.LastName = "Hristova";
            employee.Taxes = 93;
            employee.Salary = 5500;
            employee.Bonus = 193;
            employee.CalculateAllIncome();
            employee.CalculateBalance();
            employee.Print2();
            Book b2 = new Book("hitler ", 13);
            Book b3 = new Book("natii ", 3);
            Book b4 = new Book("poli ", 3);
            Book b5 = new Book("blagyy ", 1223);
            List<Book> b1 = new List<Book> { b2, b3,b4,b5 };
          
            Magazine m1 = new Magazine("cosmo", 1);
            Magazine m2 = new Magazine("nana", 2);
            Magazine m3 = new Magazine("natii", 32);
            Magazine m4 = new Magazine("xxx", 322);
            Magazine m5 = new Magazine("aaaa", 342);
            Magazine m6 = new Magazine("zzzz", 444);
          List<Magazine >m = new List<Magazine>  { m1, m2, m3, m4, m5, m6 };
            
            foreach (var item in MagazineAndBookSorter.Sort(b1, m))
            {
                Console.WriteLine(item);
            }
        }
    }
}
