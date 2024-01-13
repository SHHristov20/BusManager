using BusManager.Core.Interfaces;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Bitmap GenerateQrCodeForTicket(Ticket ticket)
        {
            QRCodeGenerator qrCodeGenerator = new();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(ticket.Code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(9);
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
    }
}
