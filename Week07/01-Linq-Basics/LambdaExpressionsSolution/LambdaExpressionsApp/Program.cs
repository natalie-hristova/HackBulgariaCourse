using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsApp
{
    class Program
    {

        static void Main(string[] args)
        {
            LambdaExpressions<int> list = new LambdaExpressions<int>();
           // Program observer = new Program();
           // list.CollectionChanged += observer = 
             //   delegate (object sender, EventArgs argis)
             //{
             //    LambdaExpressions<int> h = (LambdaExpressions<int>)sender;
             //    Console.WriteLine("Something happened to the list");
             //};


            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.RemoveAt(3);
            list.RemoveAt(2);
        }
    }
  
}

 