using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                        new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //--Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 5, 15, 11, 00, 00,
                                                        new TimeSpan(8, 0, 0)),
                HasChanges = true
            };

            //-- Act
            var actual = orderRepository.Save(updatedOrder);

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingDate()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(10)
            {
                OrderDate = null,
                HasChanges = true
            };

            //-- Act
            var actual = orderRepository.Save(updatedOrder);

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}