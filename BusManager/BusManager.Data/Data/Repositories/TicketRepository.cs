using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;

namespace BusManager.Data.Data.Repositories
{
    public class TicketRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public TicketRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Ticket?> CreateTicket(Ticket ticket)
        {
            try
            {
                await _dbContext.Tickets.AddAsync(ticket);
                await _dbContext.SaveChangesAsync();
                return ticket;
            }
            catch
            {
                return null;
            }
        }
    }
}
