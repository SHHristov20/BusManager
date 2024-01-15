using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
using BusManager.Data.Data.Contexts;

namespace BusManager.Tests
{
    [TestFixture]
    public class TicketRepositoryTests
    {
        private BusManagerDbContext _dbContext;
        private TicketRepository _ticketRepository;

        [SetUp]
        public void Setup()
        {
            _dbContext = new BusManagerDbContext();
            _ticketRepository = new TicketRepository(_dbContext);
        }

        [Test]
        public async Task CreateTicket_ShouldCreateTicket()
        {
            // Arrange
            var ticket = new Ticket
            {
                Code = "ABC123",
                BuyerId = 1,
                ScheduleId = 1
            };

            // Act
            var createdTicket = await _ticketRepository.CreateTicket(ticket);

            // Assert
            Assert.IsNotNull(createdTicket);
            Assert.AreEqual("ABC123", createdTicket.Code);
        }

        [Test]
        public async Task CheckTicket_ShouldReturnTicketOrNull()
        {
            // Arrange
            var ticketRepository = new TicketRepository(_dbContext);

            var ticket = new Ticket
            {
                Code = "XYZ456",
                BuyerId = 1,
                ScheduleId = 1
            };

            await ticketRepository.CreateTicket(ticket);

            // Act
            var checkedTicket = await ticketRepository.CheckTicket("XYZ456");

            // Assert
            Assert.IsNotNull(checkedTicket);
            Assert.AreEqual("XYZ456", checkedTicket.Code);
        }
    }
}
