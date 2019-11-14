using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// Retrieve all orders.
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        public bool Save()
        {
            return true;
        }

    }
}
