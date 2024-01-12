﻿using BusManager.Core.Implementations;
using BusManager.Core.Interfaces;
using BusManager.Data.Models;
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
    public partial class ScheduleManager : Form
    {
        public ScheduleManager()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            this.PopulateStationsList();
            return this.Panel;
        }
        private void priceField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
            else if (char.IsDigit(e.KeyChar) && ((sender as TextBox).Text.Contains('.')))
            {
                int dotIndex = (sender as TextBox).Text.IndexOf('.');
                int decimalPlaces = (sender as TextBox).Text.Length - dotIndex - 1;
                if (decimalPlaces >= 2) e.Handled = true;
            }
            if ((sender as TextBox).Text.Replace(".", "").Length >= 6 && e.KeyChar != '\b') e.Handled = true;
            if (e.KeyChar == (char)22) e.Handled = true;
        }
        private async void PopulateStationsList()
        {
            fromList.Items.Clear();
            toList.Items.Clear();
            var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
            List<Station> stations = await stationService.GetAllStationsList();
            stations.Sort((s1, s2) => string.Compare(s1.City?.Name, s2.City?.Name, StringComparison.Ordinal));
            for (int i = 0; i < stations.Count; i++)
            {
                string name = stations[i].Name;
                string city = stations[i].City.Name;
                fromList.Items.Add($"{city} - {name}");
                toList.Items.Add($"{city} - {name}");
            }
            LoadSchedulesTable();

        }
        private async void LoadSchedulesTable()
        {
            schedulesTable.Controls.Clear();
            var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
            List<Schedule> schedules = await scheduleService.GetAllSchedulesList();
            for (int i = 0; i < schedules.Count; i++)
            {
                Panel panel = new Panel();
                panel.Width = 500;
                panel.Height = 50;
                Label stationName = new Label();
                Label stationInfo = new Label();
                Button deleteStation = new Button();
                stationName.Text = $"{schedules[i].FromStation.City.Name} - {schedules[i].ToStation.City.Name}";
                stationName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                stationName.AutoSize = true;
                stationName.Anchor = AnchorStyles.Left;
                stationInfo.Text = $"{schedules[i].FromStation.Name} - {schedules[i].ToStation.Name}";
                stationInfo.Location = new Point(0, 20);
                stationInfo.AutoSize = true;
                deleteStation.Text = "Delete schedule";
                deleteStation.AutoSize = true;
                deleteStation.Location = new Point(370, panel.Height / 2 - deleteStation.Height / 2);
                int stationIndex = i;
                deleteStation.Click += (sender, e) => DeleteStationButton_Click(sender, e, schedules[stationIndex], panel);
                panel.Controls.Add(stationName);
                panel.Controls.Add(stationInfo);
                panel.Controls.Add(deleteStation);
                this.schedulesTable.Controls.Add(panel, 0, i);
            }
            schedulesTable.PerformLayout();
        }

        private async void AddScheduleToTable()
        {
            var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
            Schedule schedule = await scheduleService.GetLastAddedSchedule();
            Panel panel = new Panel();
            panel.Width = 500;
            panel.Height = 50;
            Label stationName = new Label();
            Label stationInfo = new Label();
            Button deleteStation = new Button();
            stationName.Text = $"{schedule.FromStation.City.Name} - {schedule.ToStation.City.Name}";
            stationName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            stationName.AutoSize = true;
            stationName.Anchor = AnchorStyles.Left;
            stationInfo.Text = $"{schedule.FromStation.Name} - {schedule.ToStation.Name}";
            stationInfo.Location = new Point(0, 20);
            stationInfo.AutoSize = true;
            deleteStation.Text = "Delete station";
            deleteStation.AutoSize = true;
            deleteStation.Location = new Point(370, panel.Height / 2 - deleteStation.Height / 2);
            deleteStation.Click += (sender, e) => DeleteStationButton_Click(sender, e, schedule, panel);
            panel.Controls.Add(stationName);
            panel.Controls.Add(stationInfo);
            panel.Controls.Add(deleteStation);
            this.schedulesTable.Controls.Add(panel);
        }
        private async void DeleteStationButton_Click(object? sender, EventArgs e, Schedule schedule, Panel panel)
        {
            var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
            bool success = await scheduleService.DeleteSchedule(schedule);
            if (success)
            {
                panel.Controls.Clear();
                panel.Dispose();
            }
            else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }

        private async void addScheduleButton_Click(object sender, EventArgs e)
        {
            if (this.fromList.SelectedIndex == -1) this.fieldsErrorProvider.SetError(this.fromList, "From station is required!");
            else this.fieldsErrorProvider.SetError(this.fromList, string.Empty);
            if (this.toList.SelectedIndex == -1) this.fieldsErrorProvider.SetError(this.toList, "To station is required!");
            else if(this.fromList.SelectedIndex == this.toList.SelectedIndex) this.fieldsErrorProvider.SetError(this.toList, "To and From stations cannot be the same!");
            else this.fieldsErrorProvider.SetError(this.toList, string.Empty);
            if (this.datePicker.Value <= DateTime.Now) this.fieldsErrorProvider.SetError(this.datePicker, "Time and Date must be later!");
            else this.fieldsErrorProvider.SetError(this.datePicker, string.Empty);
            if (!float.TryParse(priceField.Text, out _)) this.fieldsErrorProvider.SetError(this.priceField, "Invalid price!");
            else this.fieldsErrorProvider.SetError(this.priceField, string.Empty);
            if (string.IsNullOrEmpty(fieldsErrorProvider.GetError(fromList)) && string.IsNullOrEmpty(fieldsErrorProvider.GetError(toList)) && string.IsNullOrEmpty(fieldsErrorProvider.GetError(datePicker)) && string.IsNullOrEmpty(fieldsErrorProvider.GetError(priceField)))
            {
                var stationService = WindowManager.Instance.serviceProvider.GetService<IStationService>();
                var scheduleService = WindowManager.Instance.serviceProvider.GetService<IScheduleService>();
                List<Station> stations = await stationService.GetAllStationsList();
                stations.Sort((s1, s2) => string.Compare(s1.City?.Name, s2.City?.Name, StringComparison.Ordinal));
                Station fromStation = stations[fromList.SelectedIndex];
                Station toStation = stations[toList.SelectedIndex];
                bool success = await scheduleService.CreateSchedule(fromStation, toStation, datePicker.Value, float.Parse(priceField.Text));
                AddScheduleToTable();
                if (!success) MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manageStationsButton_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.LoadScene(WindowManager.SCENES.STATION_MANAGER);
        }
    }
}
