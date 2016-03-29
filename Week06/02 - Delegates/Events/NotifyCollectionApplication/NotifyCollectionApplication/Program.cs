using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyCollectionApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NotifyCollection<int> list = new NotifyCollection<int>();
           f observer = new f();
            list.CollectionChanged += f.HandleEvent;


            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.RemoveAt(3);
            list.RemoveAt(2);
        }
    }
    class f
    {
        public static  void HandleEvent(object sender, EventArgs args)
        {
            NotifyCollection<int> h = (NotifyCollection<int>)sender;
            Console.WriteLine("Something happened to the list");
        }
    }
}
