using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void Price_Returns_Fixed_Price_120()
        {
            // Arrange
            var mc = new MC();

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(120.0, result);
        }

        [TestMethod]
        public void VehicleType_Returns_MC()
        {
            // Arrange
            var mc = new MC();

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result);
        }
    }
}
