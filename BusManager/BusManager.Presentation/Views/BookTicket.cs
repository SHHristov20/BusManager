using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Printing;

namespace BusManager.Presentation.Views
{
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            PopulateCitiesList();
            return Panel;
        }
        private async void PopulateCitiesList()
        {
            fromList.Items.Clear();
            toList.Items.Clear();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<string> cities = await stationService.GetAllCitiesStrings();
            fromList.Items.AddRange([.. cities]);
            toList.Items.AddRange([.. cities]);
            var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
            List<Schedule> schedules = await scheduleService.GetSchedulesForToday();
            LoadSchedules(schedules);
        }
        private void LoadSchedules(List<Schedule> schedules)
        {
            schedulesTable.Controls.Clear();
            foreach (Control c in schedulesTable.Controls) c.Dispose();
            for (int i = 0; i < schedules.Count; i++)
            {
                Panel panel = new();
                panel.Width = 800;
                panel.Height = 50;
                Label route = new();
                Label stationInfo = new();
                Label date = new();
                Label time = new();
                Label price = new();
                Button buyTicket = new();
                route.Text = $"{schedules[i].FromStation.City.Name} - {schedules[i].ToStation.City.Name}";
                route.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                route.AutoSize = true;
                route.Anchor = AnchorStyles.Left;
                stationInfo.Text = $"{schedules[i].FromStation.Name} - {schedules[i].ToStation.Name}";
                stationInfo.Location = new Point(0, 20);
                stationInfo.AutoSize = true;
                date.Text = $"Leaves {schedules[i].Time:dd/MM/yyyy}";
                date.Location = new Point(250, 0);
                date.AutoSize = true;
                time.Text = $"at {schedules[i].Time:HH:mm}";
                time.Location = new Point(250, 20);
                time.AutoSize = true;
                price.Text = $"{schedules[i].Price:F2} BGN";
                price.Location = new Point(450, 10);
                price.AutoSize = true;
                price.Font = new Font(Label.DefaultFont.FontFamily, 15, FontStyle.Bold);
                buyTicket.Text = "Buy ticket";
                buyTicket.AutoSize = true;
                buyTicket.Location = new Point(680, panel.Height / 2 - buyTicket.Height / 2);
                int scheduleIndex = i;
                buyTicket.Click += (sender, e) => buyButton_Click(schedules[scheduleIndex]);
                panel.Controls.Add(route);
                panel.Controls.Add(stationInfo);
                panel.Controls.Add(buyTicket);
                panel.Controls.Add(time);
                panel.Controls.Add(date);
                panel.Controls.Add(price);
                this.schedulesTable.Controls.Add(panel, 0, i);
            }
            schedulesTable.PerformLayout();
        }

        private async void buyButton_Click(Schedule schedule)
        {
            WindowManager windowManager = WindowManager.Instance;
            var ticketService = windowManager.serviceProvider.GetService<ITicketService>();
            PrintPreviewDialog printPreview = new();
            PrintDocument printDocument = new();
            Ticket ticket = await ticketService.BuyTicket(schedule, windowManager.LoggedUser);
            if (ticket !=  null)
            {
                Bitmap qr = ticketService.GenerateQrCodeForTicket(ticket);
                printDocument.PrintPage += (sender, e) => this.GenerateTicket(sender, e, qr, ticket);
                printDocument.DocumentName = $"Ticket - {ticket.Code}";
                printPreview.Document = printDocument;
                printPreview.ShowDialog();
            }
            else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GenerateTicket(object sender, PrintPageEventArgs e, Bitmap qr, Ticket ticket)
        {
            Image logo = Properties.Resources.Logo;
            Font font = new ("Times New Roman", 16);
            Font fontBold = new Font(font, FontStyle.Bold);
            SolidBrush brush = new (Color.Black);
            float x = (e.PageBounds.Width - 700) / 2;
            float y = logo.Height;
            e.Graphics.DrawImage(logo, logo.Width/2, 0);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), (e.PageBounds.Width - 700) / 2, logo.Height, 700, 300);
            e.Graphics.DrawString($"Ticket - {ticket.Code}", fontBold, brush, new PointF(x, y + 5));
            e.Graphics.DrawString($"{WindowManager.Instance.LoggedUser.FirstName} {WindowManager.Instance.LoggedUser.LastName}", fontBold, brush, new PointF(x, y + 50));
            e.Graphics.DrawString($"{WindowManager.Instance.LoggedUser.Email}", font, brush, new PointF(x, y + 75));
            e.Graphics.DrawString($"{ticket.Schedule.FromStation.City.Name} - {ticket.Schedule.ToStation.City.Name}", fontBold, brush, new PointF(x, y + 131));
            e.Graphics.DrawString($"{ticket.Schedule.FromStation.Name} - {ticket.Schedule.ToStation.Name}", font, brush, new PointF(x, y + 156));
            e.Graphics.DrawString($"Leaves {ticket.Schedule.Time:dd/MM/yyyy} at {ticket.Schedule.Time:HH:mm}", font, brush, new PointF(x, y + 181));
            e.Graphics.DrawImage(qr, e.PageBounds.Width - qr.Width - 100, logo.Height + (300 - qr.Height) / 2);
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            if (fromList.SelectedIndex != -1 && toList.SelectedIndex != -1)
            {
                City from = await stationService.GetCityByName(fromList.SelectedItem.ToString());
                City to = await stationService.GetCityByName(toList.SelectedItem.ToString());
                List<Schedule> schedules = await scheduleService.GetSpecificSchedules(from, to, datePicker.Value);
                LoadSchedules(schedules);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            //windowManager.LoadScene(WindowManager.SCENES.LOGIN);
            windowManager.LoadScene(WindowManager.SCENES.SCHEDULE_MANAGER);
        }
    }
}
