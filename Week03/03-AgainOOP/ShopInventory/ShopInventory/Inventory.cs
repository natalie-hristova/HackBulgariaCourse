using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatTax;

namespace ShopInventory
{
    public class Inventory
    {

        List<ShopInventory.Product> list = new List<Product>();

        public Inventory(List<ShopInventory.Product> list)
        {
            this.list = list;
        }

        public double Audit()
        {
            double allMoney = 0;
            for (int i = 0; i < list.Count; i++)
            {
                allMoney += list[i].PriceAfter * list[i].Quantity;
            }
            return allMoney;
        }

        public double RequestOrder(MixedOrder order)
        {
            double sum = 0;
            for (int i = 0; i < order.mixedOrder.Count; i++)
            {
                if (order.mixedOrder.ElementAt(i).productID == (list[i].ProductId))
                {
                    if (order.mixedOrder.ElementAt(i).quantity > (list[i].Quantity))
                    {
                        throw new NotAvailableInInventoryException("The order can not be made!");
                    }
                    else
                        sum += order.mixedOrder.ElementAt(i).quantity * list[i].PriceAfter;
                }
            }
            return sum;
        }

    }
}
