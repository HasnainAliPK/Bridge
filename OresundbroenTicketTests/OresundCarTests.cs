using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbroenTicketLibrary;
using System;

namespace OresundbroenTicketTests
{
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void Price_NoBroBizz_Returns_460()
        {
            var car = new OresundCar { HasBroBizz = false };
            Assert.AreEqual(460.0, car.Price());
        }

        [TestMethod]
        public void Price_WithBroBizz_Returns_178()
        {
            var car = new OresundCar { HasBroBizz = true };
            Assert.AreEqual(178.0, car.Price());
        }

        [TestMethod]
        public void VehicleType_Returns_OresundCar()
        {
            var car = new OresundCar();
            Assert.AreEqual("Oresund car", car.VehicleType());
        }
    }
}