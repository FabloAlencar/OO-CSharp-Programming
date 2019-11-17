using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the address id
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard-coded values to return
            // a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Sienna";
                address.StreetLine2 = "39";
                address.City = "Warsaw";
                address.State = "Mazowieckie";
                address.Country = "Poland";
                address.PostalCode = "00-121";
            }
            return address;
        }

        /// <summary>
        /// Retrieve all addresses.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Address> RetrieveByCustomerID(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.

            // Temporary hard-coded values to return
            // a set of addresses for a customer
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Sienna",
                StreetLine2 = "1",
                City = "Warsaw",
                State = "Mazowieckie",
                Country = "Poland",
                PostalCode = "00-121"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Sienna",
                StreetLine2 = "2",
                City = "Warsaw",
                State = "Mazowieckie",
                Country = "Poland",
                PostalCode = "00-121"
            };
            addressList.Add(address);

            return addressList;
        }


        /// <summary>
        /// Saves the current address.
        /// </summary>
        public bool Save()
        {
            return true;
        }
    }
}