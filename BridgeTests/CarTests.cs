using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bridge;

namespace BridgeTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_Returns_Fixed_Price_230()
        {
            // Arrange
            var car = new Car();

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(230.0, result);
        }

        [TestMethod]
        public void VehicleType_Returns_Car()
        {
            // Arrange
            var car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }
    }
}