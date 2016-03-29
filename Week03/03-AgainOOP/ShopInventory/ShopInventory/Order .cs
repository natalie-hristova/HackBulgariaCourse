using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class Order
    {
        public int productID;
        public int quantity;

        public Order(int productID, int quantity)
        {
            this.productID = productID;
            this.quantity = quantity;
        }


    }
}
