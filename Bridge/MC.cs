using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a motorcycle crossing the bridge
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        /// <returns>Fixed price of 120 DKK.</returns>
        public override double Price()
        {
            return 120.0;
        }

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>String "MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
