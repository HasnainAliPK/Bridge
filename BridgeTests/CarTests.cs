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
            Vehicle car = new Car();
            Assert.AreEqual(230.0, car.Price());
        }

        [TestMethod]
        public void Price_Returns_Discounted_Price_With_BroBizz()
        {
            Vehicle car = new Car { HasBroBizz = true };
            Assert.AreEqual(207.0, car.Price(), 0.01); // 10% rabat = 207 kr.
        }

        [TestMethod]
        public void VehicleType_Returns_Car()
        {
            Vehicle car = new Car();
            Assert.AreEqual("Car", car.VehicleType());
        }
    }
}