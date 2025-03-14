using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository for managing Storebælt tickets
    /// </summary>
    public class TicketRepository : IRepository
    {
        private static List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a new ticket to the repository
        /// </summary>
        /// <param name="vehicle">The vehicle to add</param>
        public void AddTicket(Vehicle vehicle)
        {
            _tickets.Add(vehicle);
        }

        /// <summary>
        /// Retrieves all tickets in the repository
        /// </summary>
        /// <returns>A list of all vehicles</returns>
        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }

        /// <summary>
        /// Retrieves all tickets for a specific license plate
        /// </summary>
        /// <param name="licensePlate">The license plate to search for</param>
        /// <returns>A list of vehicles with the specified license plate</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            return _tickets.Where(v => v.LicensePlate == licensePlate).ToList();
        }
    }
}
