using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Represents a car crossing Storebæltw with weekend discounts
    /// </summary>
    public class StoreBaeltCar : Car
    {

        /// <summary>
        /// Returns the price for crossing Storebælt. 
        /// A 15% weekend discount is applied if the date is Saturday or Sunday. 
        /// A 10% BroBizz discount is applied afterwards if HasBroBizz is true
        /// </summary>
        /// <returns>The final price in DKK.</returns>
        public override double Price()
        {
            double price = 230.0;

            // Weekend-rabat (15%)
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85;
            }

            // BroBizz-rabat (10% yderligere)
            if (HasBroBizz)
            {
                price *= 0.9;
            }

            return price;
        }

    }
}
