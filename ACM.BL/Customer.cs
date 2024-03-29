﻿using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {
        }

        public Customer(int customerID)
        {
            CustomerId = customerID;
            AddressList = new List<Address>();
        }

        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }
        public List<Address> AddressList { get; set; }

        public int CustomerId { get; private set; }
        public int CustomerType { get; private set; }
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

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}