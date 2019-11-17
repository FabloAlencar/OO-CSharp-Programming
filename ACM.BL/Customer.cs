using System.Collections.Generic;

//test commit - adding .gitignore file

namespace ACM.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {
        }

        public Customer(int customerID)
        {
            CustomerId = customerID;
            AdressList = new List<Address>();
        }

        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }
        public List<Address> AdressList { get; set; }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
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
        /// Validates the customer data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}