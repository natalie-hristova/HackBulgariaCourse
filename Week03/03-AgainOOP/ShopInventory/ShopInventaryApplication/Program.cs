using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventaryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopInventory.Product minion1 = new ShopInventory.Product(1, "Bulgaria", "toy", 100, 123);
            ShopInventory.Product minion2 = new ShopInventory.Product(5, "Bulgaria", "book", 20, 234);
            ShopInventory.Product minion3 = new ShopInventory.Product(10, "Bulgaria", "cd", 10, 345);
            ShopInventory.Product minion4 = new ShopInventory.Product(20, "Bulgaria", "banana", 15, 456);
            ShopInventory.Order order1 = new ShopInventory.Order(123, 10);
            ShopInventory.Order order2 = new ShopInventory.Order(234, 10);
            List<ShopInventory.Order> orders = new List<ShopInventory.Order>() { order1 };
            ShopInventory.MixedOrder mo = new ShopInventory.MixedOrder(orders);
            List<ShopInventory.Product> sip = new List<ShopInventory.Product>() { minion1, minion2, minion3 };
            ShopInventory.Inventory shi = new ShopInventory.Inventory(sip);
            Console.WriteLine(shi.Audit());
            Console.WriteLine(shi.RequestOrder(mo));
        }
    }
}
