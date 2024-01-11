using BusManager.Core.Interfaces;
using BusManager.Data.Migrations;
using BusManager.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManager.Presentation.Views
{
    public partial class StationManager : Form
    {
        public StationManager()
        {
            InitializeComponent();

        }
        public Panel GetPanel()
        {
            this.PopulateCitiesList();
            return this.Panel;
        }

        private async void PopulateCitiesList(/*object sender, PaintEventArgs e*/)
        {
            stationCityList.Items.Clear();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<string> cities = await stationService.GetAllCitiesStrings();
            stationCityList.Items.AddRange([.. cities]);
            this.LoadStationsTable();

        }
        private async void LoadStationsTable()
        {
            //stationsTable.RowStyles[0].;
            stationsTable.Controls.Clear();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<Station> stations = await stationService.GetAllStationsList();
            for (int i = 0; i < stations.Count; i++)
            {
                Panel panel = new Panel();
                panel.Width = 500;
                panel.Height = 50;
                Label stationName = new Label();
                Label stationInfo = new Label();
                Button deleteStation = new Button();
                stationName.Text = $"{stations[i].Name}";
                stationName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                stationName.AutoSize = true;
                stationName.Anchor = AnchorStyles.Left;
                stationInfo.Text = $"City: {stations[i].City.Name}   Address: {stations[i].Address}";
                stationInfo.Location = new Point(0, 20);
                stationInfo.AutoSize = true;
                deleteStation.Text = "Delete station";
                deleteStation.AutoSize = true;
                deleteStation.Location = new Point(370, panel.Height / 2 - deleteStation.Height / 2);
                int stationIndex = i;
                deleteStation.Click += (sender, e) => DeleteStationButton_Click(sender, e, stations[stationIndex], panel);
                panel.Controls.Add(stationName);
                panel.Controls.Add(stationInfo);
                panel.Controls.Add(deleteStation);
                this.stationsTable.Controls.Add(panel, 0, i);
            }
            stationsTable.PerformLayout();
        }

        private async void AddStationToTable()
        {
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            Station station = await stationService.GetLastAddedStation();
            Panel panel = new Panel();
            panel.Width = 500;
            panel.Height = 50;
            Label stationName = new Label();
            Label stationInfo = new Label();
            Button deleteStation = new Button();
            stationName.Text = $"{station.Name}";
            stationName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            stationName.AutoSize = true;
            stationName.Anchor = AnchorStyles.Left;
            stationInfo.Text = $"City: {station.City.Name}   Address: {station.Address}";
            stationInfo.Location = new Point(0, 20);
            stationInfo.AutoSize = true;
            deleteStation.Text = "Delete station";
            deleteStation.AutoSize = true;
            deleteStation.Location = new Point(370, panel.Height / 2 - deleteStation.Height / 2);
            deleteStation.Click += (sender, e) => DeleteStationButton_Click(sender, e, station, panel);
            panel.Controls.Add(stationName);
            panel.Controls.Add(stationInfo);
            panel.Controls.Add(deleteStation);
            this.stationsTable.Controls.Add(panel);
        }
        private async void DeleteStationButton_Click(object? sender, EventArgs e, Station station, Panel panel)
        {
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            bool success = await stationService.DeleteStation(station);
            if (success)
            {
                panel.Controls.Clear();
                panel.Dispose();
            }
            else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void AddStationButton_Click(object sender, EventArgs e)
        {
            if (this.stationNameField.Text.Length <= 0) this.errorProvider1.SetError(this.stationNameField, "Name is required.");
            else this.errorProvider1.SetError(this.stationNameField, string.Empty);
            if (this.stationAddressField.Text.Length <= 0) this.errorProvider1.SetError(this.stationAddressField, "Address is required.");
            else this.errorProvider1.SetError(this.stationAddressField, string.Empty);
            if (this.stationCityList.SelectedIndex == -1) this.errorProvider1.SetError(this.stationCityList, "City is required.");
            else this.errorProvider1.SetError(this.stationCityList, string.Empty);
            if (string.IsNullOrEmpty(errorProvider1.GetError(stationNameField)) && string.IsNullOrEmpty(errorProvider1.GetError(stationAddressField)) && string.IsNullOrEmpty(errorProvider1.GetError(stationCityList)))
            {
                var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
                bool success = await stationService.CreateStation(this.stationNameField.Text, this.stationAddressField.Text, this.stationCityList.Text);
                AddStationToTable();
                if (!success) MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }
    }
}
