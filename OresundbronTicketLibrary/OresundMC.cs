using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundbroenTicketLibrary
{
    /// <summary>
    /// Represents a motorcycle crossing Øresundsbroen.
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Returns the price for crossing Øresundsbroen.
        /// A BroBizz discount applies if HasBroBizz is true.
        /// </summary>
        /// <returns>The final price in DKK.</returns>
        public override double Price()
        {
            return HasBroBizz ? 92.0 : 235.0;
        }

        /// <summary>
        /// Returns the vehicle type.
        /// </summary>
        /// <returns>String "Oresund MC".</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
