namespace Bridge
{
    /// <summary>
    /// Represents a car crossing the bridge
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        /// <returns>Fixed price of 230 DKK.</returns>
        public override double Price()
        {
            return 230.0;
        }

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>String "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
