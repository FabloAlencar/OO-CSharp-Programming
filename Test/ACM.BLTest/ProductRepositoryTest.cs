using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void ValidRetrieve()
        {
            //-- Arrange
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 50.65M,
                ProductName = "C# Book",
                ProductDescription = "C# Programming"
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //--Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductName = "Assorted Title Set of 4",
                ProductDescription = "Channels Programming",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "Assorted Title Set of 4",
                ProductDescription = "Channels Programming",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}