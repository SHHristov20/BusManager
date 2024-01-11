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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<string> cities = await stationService.GetAllCitiesStrings();
            stationCityList.Items.AddRange([.. cities]);
            this.LoadStationsTable();

            for (int i = 0; i < cities.Count; i++)
            {
                //Debug.WriteLine(cities[i]);
                //Label stationName = new Label();
                //stationName.Text = cities[i];
                //stationName.Anchor = AnchorStyles.None;
                //this.stationsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                //this.stationsTable.Controls.Add(stationName, 0, i);
                //stationCityList.Items.Add(cities[i]);
            }

        }
        private async void LoadStationsTable()
        {
            //stationsTable.RowStyles[0].;
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<Station> stations = await stationService.GetAllStationsList();
            for (int i = 0; i < stations.Count; i++)
            {
                Panel panel = new Panel();
                panel.Width = 400;
                panel.Height = 50;
                Label stationName = new Label();
                Label stationInfo = new Label();
                stationName.Text = $"{stations[i].Name}";
                stationName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                stationName.AutoSize = true;
                stationName.Anchor = AnchorStyles.Left;
                stationInfo.Text = $"City: {stations[i].City.Name}   Address: {stations[i].Address}";
                stationInfo.Location = new Point(0, 20);
                stationInfo.AutoSize = true;
                panel.Controls.Add(stationName);
                panel.Controls.Add(stationInfo);
                this.stationsTable.Controls.Add(panel, 0, i);
            }
            stationsTable.PerformLayout();
        }

        private async void AddStationToTable()
        {
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            Station station = await stationService.GetLastAddedStation();
            Panel panel = new Panel();
            panel.Width = 400;
            panel.Height = 50;
            Label stationName = new Label();
            Label stationInfo = new Label();
            stationName.Text = $"{station.Name}";
            stationName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            stationName.AutoSize = true;
            stationName.Anchor = AnchorStyles.Left;
            stationInfo.Text = $"City: {station.City.Name}   Address: {station.Address}";
            stationInfo.Location = new Point(0, 20);
            stationInfo.AutoSize = true;
            panel.Controls.Add(stationName);
            panel.Controls.Add(stationInfo);
            this.stationsTable.Controls.Add(panel);
        }
        private async void AddStationButton_Click(object sender, EventArgs e)
        {
            if (this.stationNameField.Text.Length <= 0) this.errorProvider1.SetError(this.stationNameField, "Name is required.");
            else this.errorProvider1.SetError(this.stationNameField, string.Empty);
            if (this.stationAddressField.Text.Length <= 0 ) this.errorProvider1.SetError(this.stationAddressField, "Address is required.");
            else this.errorProvider1.SetError(this.stationAddressField, string.Empty);
            if (this.stationCityList.SelectedIndex == -1 ) this.errorProvider1.SetError(this.stationCityList, "City is required.");
            else this.errorProvider1.SetError(this.stationCityList, string.Empty);
            if (string.IsNullOrEmpty(errorProvider1.GetError(stationNameField)) && string.IsNullOrEmpty(errorProvider1.GetError(stationAddressField)) && string.IsNullOrEmpty(errorProvider1.GetError(stationCityList)))
            {
                var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
                bool success = await stationService.CreateStation(this.stationNameField.Text, this.stationAddressField.Text, this.stationCityList.SelectedIndex);
                AddStationToTable();
                if (success) MessageBox.Show("Success");
                else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(stationCityList.SelectedIndex);

            }
        }
    }
}
