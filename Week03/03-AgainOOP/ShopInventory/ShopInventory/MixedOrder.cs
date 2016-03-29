using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class MixedOrder
    {
        public List<Order> mixedOrder = new List<Order>();

        public MixedOrder(List<Order> mixedOrder)
        {
            this.mixedOrder = mixedOrder;

        }
    }
}
