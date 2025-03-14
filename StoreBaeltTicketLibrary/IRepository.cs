using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Interface for ticket repository management
    /// </summary>
    public interface IRepository
    {
        void AddTicket(Vehicle vehicle);
        List<Vehicle> GetAllTickets();
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}
