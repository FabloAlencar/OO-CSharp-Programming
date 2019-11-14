using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            Customer c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            int expected = 3;

            //-- Act
            int actual = Customer.InstanceCount;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Bilbo",
                EmailAdress = "Bilbo@teressa.com"
            };

            bool expected = true;

            //-- Act
            bool actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                EmailAdress = "Bilbo@teressa.com"
            };

            bool expected = false;
              
            //-- Act
            bool actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}