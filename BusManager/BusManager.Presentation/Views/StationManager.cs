using BusManager.Core.Interfaces;
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
            this.PopulateTable();
            return this.Panel;
        }

        private async void PopulateTable(/*object sender, PaintEventArgs e*/)
        {
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<string> cities = await stationService.GetAllCitiesStrings();
            //List<String> cities = new List<string> { "Burgas", "asd", "asdasd", "asdasdasdsa" };
            Debug.WriteLine("asdad");
            stationCityList.Items.AddRange([.. cities]);
            for (int i = 0; i < cities.Count; i++)
            {
                //Debug.WriteLine(cities[i]);
                //Label cityLabel = new Label();
                //cityLabel.Text = cities[i];
                //cityLabel.Anchor = AnchorStyles.None;
                //this.stationsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                //this.stationsTable.Controls.Add(cityLabel, 0, i);
                //stationCityList.Items.Add(cities[i]);
            }

        }

        private async void addStationButton_Click(object sender, EventArgs e)
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
                if (success) MessageBox.Show("Success");
                else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(stationCityList.SelectedIndex);

            }
        }
    }
}
