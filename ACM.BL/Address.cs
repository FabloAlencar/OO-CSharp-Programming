using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Address
    {
        public Address()
        {

        }

        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }

        /// <summary>
        /// Validates the address data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(AdressLine1)) isValid = false;

            return isValid;

        }
    }
}
