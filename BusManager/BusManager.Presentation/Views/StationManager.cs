using BusManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
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
            this.PopulateTable();
            return this.Panel;
        }

        private async void PopulateTable(/*object sender, PaintEventArgs e*/)
        {
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<String> cities = await stationService.GetAllCitiesStrings();
            //List<String> cities = new List<string> { "Burgas", "asd", "asdasd", "asdasdasdsa" };
            Debug.WriteLine("asdad");
            for (int i = 0; i < cities.Count; i++)
            {
                Debug.WriteLine(cities[i]);
                Label cityLabel = new Label();
                cityLabel.Text = cities[i];
                cityLabel.Anchor = AnchorStyles.None;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                this.tableLayoutPanel1.Controls.Add(cityLabel, 0, i);
            }

        }
    }
}
