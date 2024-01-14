using BusManager.Data.Models;
using System.Drawing;

namespace BusManager.Core.Interfaces
{
    public interface ITicketService
    {
        Bitmap GenerateQrCodeForTicket(Ticket ticket, int size);
        Task<Ticket?> BuyTicket(Schedule schedule, User user);
        Task<Ticket?> CheckTicket(string code);
        Task<List<Ticket>> ViewTicketsByUser(User user);
    }
}
