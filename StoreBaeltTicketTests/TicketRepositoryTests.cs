using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketTests
{
    [TestClass]
    public class TicketRepositoryTests
    {
        [TestMethod]
        public void AddTicket_AddsVehicleToRepository()
        {
            // Arrange
            var repo = new TicketRepository();
            var car = new StoreBaeltCar { LicensePlate = "AB12345", Date = DateTime.Now };

            // Act
            repo.AddTicket(car);
            var allTickets = repo.GetAllTickets();

            // Assert
            Assert.AreEqual(1, allTickets.Count);
            Assert.AreEqual("AB12345", allTickets[0].LicensePlate);
        }

        [TestMethod]
        public void GetTicketsByLicensePlate_ReturnsCorrectVehicles()
        {
            // Arrange
            var repo = new TicketRepository();
            var car1 = new StoreBaeltCar { LicensePlate = "XY98765", Date = DateTime.Now };
            var car2 = new StoreBaeltCar { LicensePlate = "AB12345", Date = DateTime.Now };
            repo.AddTicket(car1);
            repo.AddTicket(car2);

            // Act
            var result = repo.GetTicketsByLicensePlate("XY98765");

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("XY98765", result[0].LicensePlate);
        }
    }
}
