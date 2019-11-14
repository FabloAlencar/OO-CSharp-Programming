using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {

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

    }
}
