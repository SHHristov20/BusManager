using BusManager.Data.Models;
using BusManager.Presentation.Views;
using System.Drawing.Printing;

namespace BusManager.Presentation.Helpers
{
    public class PrintTicket
    {
        public static void GenerateTicket(object sender, PrintPageEventArgs e, Bitmap qr, Ticket ticket)
        {
            Image logo = Properties.Resources.Logo;
            Font font = new("Times New Roman", 16);
            Font fontBold = new(font, FontStyle.Bold);
            SolidBrush brush = new(Color.Black);
            float x = (e.PageBounds.Width - 700) / 2;
            float y = logo.Height;
            e.Graphics.DrawImage(logo, logo.Width / 2, 0);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), (e.PageBounds.Width - 700) / 2, logo.Height, 700, 300);
            e.Graphics.DrawString($"Ticket - {ticket.Code}", fontBold, brush, new PointF(x, y + 5));
            e.Graphics.DrawString($"{WindowManager.Instance.LoggedUser.FirstName} {WindowManager.Instance.LoggedUser.LastName}", fontBold, brush, new PointF(x, y + 50));
            e.Graphics.DrawString($"{WindowManager.Instance.LoggedUser.Email}", font, brush, new PointF(x, y + 75));
            e.Graphics.DrawString($"{ticket.Schedule.FromStation.City.Name} - {ticket.Schedule.ToStation.City.Name}", fontBold, brush, new PointF(x, y + 131));
            e.Graphics.DrawString($"{ticket.Schedule.FromStation.Name} - {ticket.Schedule.ToStation.Name}", font, brush, new PointF(x, y + 156));
            e.Graphics.DrawString($"Leaves {ticket.Schedule.Time:dd/MM/yyyy} at {ticket.Schedule.Time:HH:mm}", font, brush, new PointF(x, y + 181));
            e.Graphics.DrawImage(qr, e.PageBounds.Width - qr.Width - 100, logo.Height + (300 - qr.Height) / 2);
        }
    }
}
