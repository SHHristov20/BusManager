using BusManager.Data.Models;
using System.Drawing;

namespace BusManager.Core.Interfaces
{
    public interface ITicketService
    {
        Bitmap GenerateQrCodeForTicket(Ticket ticket);
        Task<Ticket?> BuyTicket(Schedule schedule, User user);
    }
}
