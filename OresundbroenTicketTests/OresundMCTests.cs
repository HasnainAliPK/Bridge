using OresundbroenTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbroenTicketTests
{
    [TestClass]
    public class OresundMCTests
    {
        [TestMethod]
        public void Price_NoBroBizz_Returns_235()
        {
            var mc = new OresundMC { HasBroBizz = false };
            Assert.AreEqual(235.0, mc.Price());
        }

        [TestMethod]
        public void Price_WithBroBizz_Returns_92()
        {
            var mc = new OresundMC { HasBroBizz = true };
            Assert.AreEqual(92.0, mc.Price());
        }

        [TestMethod]
        public void VehicleType_Returns_OresundMC()
        {
            var mc = new OresundMC();
            Assert.AreEqual("Oresund MC", mc.VehicleType());
        }
    }
}
