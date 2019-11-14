using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
        }
        public Customer( int customerID)
        {
            CustomerId = customerID;
        }

        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }  
        

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
                
        /// <summary>
        /// Validates the customer data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;

        }
    }
}