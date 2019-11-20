namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {
        }

        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Validates the address data.
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;

            return isValid;
        }
    }
}