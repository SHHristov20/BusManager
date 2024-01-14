using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace BusManager.Presentation.Views
{
    public partial class TicketValidator : Form
    {
        public TicketValidator()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            return Panel;
        }

        private void ticketInfo_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ticketInfo.ClientRectangle, SystemColors.AppWorkspace, ButtonBorderStyle.Solid);
        }

        private async void checkTicketButton_Click(object sender, EventArgs e)
        {
            if (ticketCodeField.Text.IsNullOrEmpty()) fieldErrorProvider.SetError(ticketCodeField, "Ticket code required!");
            else
            {
                fieldErrorProvider.SetError(ticketCodeField, string.Empty);
                var ticketService = WindowManager.Instance.serviceProvider.GetService<ITicketService>();
                Ticket ticket = await ticketService.CheckTicket(ticketCodeField.Text);
                if (ticket != null)
                {
                    ticketLabel.Text = $"Ticket - {ticket.Code}";
                    citiesLabel.Text = $"{ticket.Schedule.FromStation.City.Name} - {ticket.Schedule.ToStation.City.Name}";
                    citiesLabel.Location = new Point((ticketInfo.Width - citiesLabel.Width) / 2, citiesLabel.Location.Y);
                    stationsLabel.Text = $"{ticket.Schedule.FromStation.Name} - {ticket.Schedule.ToStation.Name}";
                    dateLabel.Text = $"Departure Date: {ticket.Schedule.Time:dd/MM/yyyy}";
                    timeLabel.Text = $"Departure Time: {ticket.Schedule.Time:HH:mm}";
                    nameLabel.Text = $"Name: {ticket.Buyer.FirstName} {ticket.Buyer.LastName}";
                    emailLabel.Text = $"Email: {ticket.Buyer.Email}";
                    statusLabel.Text = "VALID";
                    statusLabel.Location = new Point((statusPanel.Width - statusLabel.Width) / 2, 0);
                    statusPanel.BackColor = Color.Green;
                }
                else
                {
                    ticketLabel.Text = "Ticket - 0000000000000000";
                    citiesLabel.Text = "-";
                    citiesLabel.Location = new Point((ticketInfo.Width - citiesLabel.Width) / 2, citiesLabel.Location.Y);
                    stationsLabel.Text = "Stations:";
                    dateLabel.Text = "Departure Date:";
                    timeLabel.Text = "Departure Time:";
                    nameLabel.Text = "Name:";
                    emailLabel.Text = "Email:";
                    statusLabel.Text = "INVALID";
                    statusLabel.Location = new Point((statusPanel.Width - statusLabel.Width) / 2, 0);
                    statusPanel.BackColor = Color.DarkRed;
                }
            }
            ticketCodeField.Text = string.Empty;
        }
        private void ticketCodeField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) checkTicketButton_Click(sender, e);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }
    }
}
