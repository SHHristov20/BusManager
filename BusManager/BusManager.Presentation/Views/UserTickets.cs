using BusManager.Core.Implementations;
using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using BusManager.Presentation.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection;

namespace BusManager.Presentation.Views
{
    public partial class UserTickets : Form
    {
        private Ticket? selectedTicket;
        public UserTickets()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            LoadTicketsTable();
            return Panel;
        }
        private void bookTicketButton_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.LoadScene(WindowManager.SCENES.BOOK_TICKET);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }
        private async void LoadTicketsTable()
        {
            ticketsTable.Controls.Clear();
            foreach (Control c in ticketsTable.Controls) c.Dispose();
            var ticketService = WindowManager.Instance.serviceProvider.GetService<ITicketService>();
            List<Ticket> tickets = await ticketService.ViewTicketsByUser(WindowManager.Instance.LoggedUser);
            if (tickets.Count > 0) ViewTicket(tickets[0], ticketService.GenerateQrCodeForTicket(tickets[0], 5));
            for (int i = 0; i < tickets.Count; i++)
            {
                Panel panel = new();
                panel.Width = 500;
                panel.Height = 50;
                Label ticketRoute = new();
                Label ticketDate = new();
                Button viewTicket = new Button();
                ticketRoute.Text = $"{tickets[i].Schedule.FromStation.City.Name} - {tickets[i].Schedule.ToStation.City.Name}";
                ticketRoute.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                ticketRoute.AutoSize = true;
                ticketRoute.Anchor = AnchorStyles.Left;
                ticketDate.Text = $"Leaves {tickets[i].Schedule.Time:dd/MM:yyyy} at {tickets[i].Schedule.Time:HH:mm}";
                ticketDate.Location = new Point(0, 20);
                ticketDate.AutoSize = true;
                viewTicket.Text = "View ticket";
                viewTicket.AutoSize = true;
                viewTicket.Location = new Point(300, panel.Height / 2 - viewTicket.Height / 2);
                int ticketIndex = i;
                Bitmap qrCode = ticketService.GenerateQrCodeForTicket(tickets[i], 5);
                viewTicket.Click += (sender, e) => ViewTicket(tickets[ticketIndex], qrCode);
                panel.Controls.Add(ticketRoute);
                panel.Controls.Add(ticketDate);
                panel.Controls.Add(viewTicket);
                this.ticketsTable.Controls.Add(panel, 0, i);
            }
            ticketsTable.PerformLayout();
        }
        private void ViewTicket(Ticket ticket, Bitmap qrCode)
        {

            printButton.Click -= printButton_Click;
            selectedTicket = ticket;
            ticketLabel.Text = $"Ticket - {ticket.Code}";
            citiesLabel.Text = $"{ticket.Schedule.FromStation.City.Name} - {ticket.Schedule.ToStation.City.Name}";
            citiesLabel.Location = new Point((ticketInfo.Width - citiesLabel.Width) / 2, citiesLabel.Location.Y);
            stationsLabel.Text = $"Stations: {ticket.Schedule.FromStation.Name} - {ticket.Schedule.ToStation.Name}";
            dateLabel.Text = $"Departure Date: {ticket.Schedule.Time:dd/MM/yyyy}";
            timeLabel.Text = $"Departure Time: {ticket.Schedule.Time:HH:mm}";
            nameLabel.Text = $"Name: {ticket.Buyer.FirstName} {ticket.Buyer.LastName}";
            emailLabel.Text = $"Email: {ticket.Buyer.Email}";
            qrCodeImage.Image = qrCode;
            printButton.Show();
            printButton.Click += printButton_Click;
        }
        private void printButton_Click(object? sender, EventArgs e)
        {
                var ticketService = WindowManager.Instance.serviceProvider.GetService<ITicketService>();
                PrintPreviewDialog printPreview = new();
                PrintDocument printDocument = new();
                Bitmap qr = ticketService.GenerateQrCodeForTicket(selectedTicket, 9);
                printDocument.PrintPage += (sender, e) => PrintTicket.GenerateTicket(sender, e, qr, selectedTicket);
                printDocument.DocumentName = $"Ticket - {selectedTicket.Code}";
                printPreview.Document = printDocument;
                printPreview.ShowDialog();
        }
    }
}
