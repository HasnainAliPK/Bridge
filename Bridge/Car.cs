namespace Bridge
{
    /// <summary>
    /// Represents a car crossing the bridge.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The license plate of the car.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// The date when the car crosses the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price for crossing the bridge.
        /// </summary>
        /// <returns>Fixed price of 230 DKK.</returns>
        public double Price()
        {
            return 230.0;
        }

        /// <summary>
        /// Returns the vehicle type.
        /// </summary>
        /// <returns>String "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
