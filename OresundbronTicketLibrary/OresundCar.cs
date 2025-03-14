using Bridge;

namespace OresundbroenTicketLibrary
{
    /// <summary>
    /// Represents a car crossing Øresundsbroen
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Returns the price for crossing Øresundsbroen. 
        /// A BroBizz discount applies if HasBroBizz is true
        /// </summary>
        /// <returns>The final price in DKK.</returns>
        public override double Price()
        {
            return HasBroBizz ? 178.0 : 460.0;
        }

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>String "Oresund car"</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
