using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlate_ThrowsException_IfTooLong()
        {
            // Arrange & Act
            var car = new Car { LicensePlate = "ABCDEFGH" }; // 8 tegn, skal give fejl
        }
    }
}
