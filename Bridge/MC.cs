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
        /// Returns the price for crossing the bridge. 
        /// A BroBizz discount of 10% is applied if HasBroBizz is true
        /// </summary>
        /// <returns>The price in DKK.</returns>
        public override double Price()
        {
            double price = 120.0;
            if (HasBroBizz)
                price *= 0.9; // 10% discount

            return price;
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
