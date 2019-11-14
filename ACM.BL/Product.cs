using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { set; get; }
        public decimal? CurrentPrice { set; get; }
        public string Description { set; get; }


        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int ProductId)
        {
            return new Product();
        }

        /// <summary>
        /// Retrieve all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null)                   isValid = false;

            return isValid;

        }

    }
}
