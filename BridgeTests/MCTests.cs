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
            Vehicle mc = new MC();
            Assert.AreEqual(120.0, mc.Price());
        }

        [TestMethod]
        public void VehicleType_Returns_MC()
        {
            Vehicle mc = new MC();
            Assert.AreEqual("MC", mc.VehicleType());
        }
    }
}
