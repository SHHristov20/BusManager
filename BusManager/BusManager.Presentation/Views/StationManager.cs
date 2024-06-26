﻿using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using Microsoft.Extensions.DependencyInjection;

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

        private async void PopulateCitiesList()
        {
            stationCityList.Items.Clear();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<string> cities = await stationService.GetAllCitiesStrings();
            stationCityList.Items.AddRange([.. cities]);
            this.LoadStationsTable();

        }
        private async void LoadStationsTable()
        {
            stationsTable.Controls.Clear();
            foreach (Control c in stationsTable.Controls) c.Dispose();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<Station> stations = await stationService.GetAllStationsList();
            for (int i = 0; i < stations.Count; i++)
            {
                Panel panel = new();
                panel.Width = 500;
                panel.Height = 50;
                Label stationName = new();
                Label stationInfo = new();
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
                deleteStation.Click += (sender, e) => DeleteStationButton_Click(stations[stationIndex], panel);
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
            Label stationName = new();
            Label stationInfo = new();
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
            deleteStation.Click += (sender, e) => DeleteStationButton_Click(station, panel);
            panel.Controls.Add(stationName);
            panel.Controls.Add(stationInfo);
            panel.Controls.Add(deleteStation);
            this.stationsTable.Controls.Add(panel);
        }
        private async void DeleteStationButton_Click(Station station, Panel panel)
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
            if (this.stationNameField.Text.Length <= 0) this.fieldsErrorProvider.SetError(this.stationNameField, "Name is required!");
            else this.fieldsErrorProvider.SetError(this.stationNameField, string.Empty);
            if (this.stationAddressField.Text.Length <= 0) this.fieldsErrorProvider.SetError(this.stationAddressField, "Address is required!");
            else this.fieldsErrorProvider.SetError(this.stationAddressField, string.Empty);
            if (this.stationCityList.SelectedIndex == -1) this.fieldsErrorProvider.SetError(this.stationCityList, "City is required!");
            else this.fieldsErrorProvider.SetError(this.stationCityList, string.Empty);
            if (string.IsNullOrEmpty(fieldsErrorProvider.GetError(stationNameField)) && string.IsNullOrEmpty(fieldsErrorProvider.GetError(stationAddressField)) && string.IsNullOrEmpty(fieldsErrorProvider.GetError(stationCityList)))
            {
                var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
                bool success = await stationService.CreateStation(this.stationNameField.Text, this.stationAddressField.Text, this.stationCityList.Text);
                AddStationToTable();
                if (!success) MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }

        private void manageSchedulesButton_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.LoadScene(WindowManager.SCENES.SCHEDULE_MANAGER);
        }

        private void manageAccountsButton_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.LoadScene(WindowManager.SCENES.ACCOUNT_MANAGER);
        }
    }
}
