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
    public class MC
    {
        /// <summary>
        /// The license plate of the motorcycle
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// The date when the motorcycle crosses the bridge
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        /// <returns>Fixed price of 120 DKK.</returns>
        public double Price()
        {
            return 120.0;
        }

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>String "MC"</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
