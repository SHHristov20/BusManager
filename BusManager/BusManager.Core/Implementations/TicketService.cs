using BusManager.Core.Interfaces;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BusManager.Data.Models;

namespace BusManager.Core.Implementations
{
    public class TicketService : ITicketService
    {
        public Bitmap GenerateQrCodeForTicket(/*Ticket ticket*/)
        {
            QRCodeGenerator qrCodeGenerator = new();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode("asd", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            return qrCodeImage;
        }
    }
}
