using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fablo.alencar@hotmail.com",
                FirstName = "Fablo",
                LastName = "Alencar"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fablo.alencar@hotmail.com",
                FirstName = "Fablo",
                LastName = "Alencar",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                AddressType = 1,
                StreetLine1 = "Sienna",
                StreetLine2 = "1",
                City = "Warsaw",
                State = "Mazowieckie",
                Country = "Poland",
                PostalCode = "00-121"
                    },
            new Address()
            {
                AddressType = 1,
                StreetLine1 = "Sienna",
                StreetLine2 = "1",
                City = "Warsaw",
                State = "Mazowieckie",
                Country = "Poland",
                PostalCode = "00-121"
            }
                }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var updatedCustomer = new Customer(2)
            {
                EmailAddress = "fablo.alencar@hotmail.com",
                FirstName = "Fablo",
                LastName = "Alencar",
                HasChanges = true
            };

            //-- Act
            var actual = customerRepository.Save(updatedCustomer);

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingLastName()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var updatedCustomer = new Customer(2)
            {
                EmailAddress = "fablo.alencar@hotmail.com",
                FirstName = "Fablo",
                LastName = null,
                HasChanges = true
            };

            //-- Act
            var actual = customerRepository.Save(updatedCustomer);

            //--Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void SaveTestMissingEmail()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var updatedCustomer = new Customer(2)
            {
                EmailAddress = null,
                FirstName = "Fablo",
                LastName = "Alencar",
                HasChanges = true
            };

            //-- Act
            var actual = customerRepository.Save(updatedCustomer);

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}