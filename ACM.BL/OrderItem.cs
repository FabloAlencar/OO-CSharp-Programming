using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int ordemItemId)
        {
            OrdemItemId = ordemItemId;
        }

        public int OrdemItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        /// <summary>
        /// Retrieve one order item .
        /// </summary>
        public OrderItem Retrieve(int OrderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all order items .
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the ordem item data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity  <= 0)         isValid = false;
            if (ProductId <= 0)         isValid = false;
            if (PurchasePrice == null)  isValid = false;
            
            return isValid;

        }

    }
}
