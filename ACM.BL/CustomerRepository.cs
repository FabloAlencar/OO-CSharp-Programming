using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class CustomerRepository
    {

        /// <summary>
        /// Retrieve one costumer.
        /// </summary>
        public Customer Retrieve(int customerID)
        {
            return new Customer();
        }

        /// <summary>
        /// Retrieve all costumers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current costumer.
        /// </summary>
        public bool Save()
        {
            return true;
        }

    }
}
