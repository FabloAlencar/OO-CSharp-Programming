using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

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

        /// <summary>
        /// Validates the order data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
