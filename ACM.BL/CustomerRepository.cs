using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Retrieve one costumer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the customer id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary har-coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fablo.alencar@hotmail.com";
                customer.FirstName = "Fablo";
                customer.LastName = "Alencar";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerId).
                                            ToList();
            }
            return customer;
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