using BusManager.Core.Interfaces;
using QRCoder;
using System.Drawing;
using BusManager.Data.Models;
using BusManager.Core.Helpers;
using BusManager.Data.Data.Repositories;

namespace BusManager.Core.Implementations
{
    public class TicketService : ITicketService
    {
        private readonly TicketRepository _ticketRepository;
        public TicketService(TicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public Bitmap GenerateQrCodeForTicket(Ticket ticket, int size)
        {
            QRCodeGenerator qrCodeGenerator = new();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(ticket.Code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(size);
            return qrCodeImage;
        }
        public async Task<Ticket?> BuyTicket(Schedule schedule, User user)
        {
            Ticket ticket = new()
            {
                Buyer = user,
                Schedule = schedule,
                Code = CodeGenerator.Generate(16)
            };
            return await _ticketRepository.CreateTicket(ticket);
        }
        public async Task<Ticket?> CheckTicket(string code)
        {
            return await _ticketRepository.CheckTicket(code);
        }
        public async Task<List<Ticket>> ViewTicketsByUser(User user)
        {
            return await _ticketRepository.ViewTicketsByUser(user);
        }
    }
}
