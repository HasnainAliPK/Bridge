namespace Bridge
{
    /// <summary>
    /// Represents a car crossing the bridge
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the price for crossing the bridge. 
        /// A BroBizz discount of 10% is applied if HasBroBizz is true
        /// </summary>
        /// <returns>The price in DKK.</returns>
        public override double Price()
        {
            double price = 230.0;
            if (HasBroBizz)
                price *= 0.9; // 10% discount

            return price;
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
