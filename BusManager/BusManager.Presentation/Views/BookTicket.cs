using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using BusManager.Presentation.Properties;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoadSchedulesForToday();
        }
        private async void LoadSchedulesForToday()
        {
            schedulesTable.Controls.Clear();
            foreach (Control c in schedulesTable.Controls) c.Dispose();
            var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
            List<Schedule> schedules = await scheduleService.GetSchedulesForToday();
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
            var ticketService = WindowManager.Instance.serviceProvider.GetService<ITicketService>();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            Bitmap qr = ticketService.GenerateQrCodeForTicket();
            printDocument.PrintPage += (sender, e) => this.pd_PrintPage(sender, e, qr, schedule);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev, Bitmap qr, Schedule schedule)
        {
            Image logo = Properties.Resources.Logo;
            ev.Graphics.DrawImage(logo, logo.Width/2, 0);
            //draw rectangle centered
            ev.Graphics.DrawRectangle(new Pen(Color.Black, 2), (ev.PageBounds.Width - 700) / 2, logo.Height, 700, 300);
            // draw string
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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
