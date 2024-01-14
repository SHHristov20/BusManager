using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;

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
            catch { return null; }
        }
        public async Task<Ticket?> CheckTicket(string code)
        {
            try
            {
                return await _dbContext.Tickets
                    .Where(t => t.Code == code)
                    .Include(t => t.Schedule.FromStation)
                    .Include(t => t.Schedule.ToStation)
                    .Include(t => t.Schedule.FromStation.City)
                    .Include(t => t.Schedule.ToStation.City)
                    .Include(t => t.Buyer)
                    .FirstOrDefaultAsync();
            }
            catch { return null; }
        }
        public async Task<List<Ticket>> ViewTicketsByUser(User user)
        {
            try
            {
                return await _dbContext.Tickets
                    .Where(t => t.Buyer == user)
                    .Include(t => t.Schedule.FromStation)
                    .Include(t => t.Schedule.ToStation)
                    .Include(t => t.Schedule.FromStation.City)
                    .Include(t => t.Schedule.ToStation.City)
                    .Include(t => t.Buyer)
                    .OrderByDescending(t => t.Schedule.Time)
                    .ToListAsync();
            }
            catch { return []; }
        }
    }
}
