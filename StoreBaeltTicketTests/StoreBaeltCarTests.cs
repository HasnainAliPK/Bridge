using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;

namespace StoreBaeltTicketTests
{
    [TestClass]
    public class StoreBaeltCarTests
    {
        [TestMethod]
        public void Price_NoDiscount_Returns_230()
        {
            // Arrange
            var car = new StoreBaeltCar { Date = new DateTime(2024, 3, 11), HasBroBizz = false }; // Mandag

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(230.0, result, 0.01);
        }

        [TestMethod]
        public void Price_WeekendDiscount_Returns_195_5()
        {
            // Arrange
            var car = new StoreBaeltCar { Date = new DateTime(2024, 3, 16), HasBroBizz = false }; // Lørdag

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(195.5, result, 0.01); // 230 * 0.85 = 195.5
        }

        [TestMethod]
        public void Price_BroBizzDiscount_Returns_207()
        {
            // Arrange
            var car = new StoreBaeltCar { Date = new DateTime(2024, 3, 11), HasBroBizz = true }; // Mandag

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(207.0, result, 0.01); // 230 * 0.9 = 207
        }

        [TestMethod]
        public void Price_WeekendAndBroBizzDiscount_Returns_175_95()
        {
            // Arrange
            var car = new StoreBaeltCar { Date = new DateTime(2024, 3, 16), HasBroBizz = true }; // Lørdag

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(175.95, result, 0.01); // 230 * 0.85 * 0.9 = 175.95
        }
    }
}