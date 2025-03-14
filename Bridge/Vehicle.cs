using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Base class for all vehicles crossing the bridge
    /// </summary>
    public abstract class Vehicle
    {

        /// <summary>
        /// Stores the licensplate in Vehicle class
        /// </summary>
        private string _licensePlate;

        /// <summary>
        /// The license plate of the vehicle. Cannot be longer than 7 characters
        /// </summary>
        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                _licensePlate = value;
            }
        }

        /// <summary>
        /// The date when the vehicle crosses the bridge
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Abstract method to return the price of crossing the bridge
        /// </summary>
        /// <returns>The price in DKK.</returns>
        public abstract double Price();

        /// <summary>
        /// Abstract method to return the type of vehicle
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public abstract string VehicleType();
    }
}
