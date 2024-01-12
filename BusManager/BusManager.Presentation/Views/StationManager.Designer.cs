using BusManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BusManager.Presentation.Views
{
    partial class StationManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Panel = new Panel();
            addStationButton = new Button();
            stationCityLabel = new Label();
            stationAddressLabel = new Label();
            stationNameLabel = new Label();
            stationCityList = new ComboBox();
            stationAddressField = new TextBox();
            stationNameField = new TextBox();
            createStationLabel = new Label();
            stationsTable = new TableLayoutPanel();
            navPanel = new Panel();
            logoutButton = new Button();
            manageStationsButton = new Button();
            manageSchedulesButton = new Button();
            manageAccountsButton = new Button();
            fieldsErrorProvider = new ErrorProvider(components);
            Panel.SuspendLayout();
            navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fieldsErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(addStationButton);
            Panel.Controls.Add(stationCityLabel);
            Panel.Controls.Add(stationAddressLabel);
            Panel.Controls.Add(stationNameLabel);
            Panel.Controls.Add(stationCityList);
            Panel.Controls.Add(stationAddressField);
            Panel.Controls.Add(stationNameField);
            Panel.Controls.Add(createStationLabel);
            Panel.Controls.Add(stationsTable);
            Panel.Controls.Add(navPanel);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 1;
            // 
            // addStationButton
            // 
            addStationButton.Location = new Point(168, 408);
            addStationButton.Name = "addStationButton";
            addStationButton.Size = new Size(100, 30);
            addStationButton.TabIndex = 9;
            addStationButton.Text = "Add station";
            addStationButton.UseVisualStyleBackColor = true;
            addStationButton.Click += AddStationButton_Click;
            // 
            // stationCityLabel
            // 
            stationCityLabel.AutoSize = true;
            stationCityLabel.Font = new Font("Segoe UI", 10F);
            stationCityLabel.ForeColor = SystemColors.ControlText;
            stationCityLabel.Location = new Point(12, 214);
            stationCityLabel.Name = "stationCityLabel";
            stationCityLabel.Size = new Size(36, 19);
            stationCityLabel.TabIndex = 8;
            stationCityLabel.Text = "City:";
            // 
            // stationAddressLabel
            // 
            stationAddressLabel.AutoSize = true;
            stationAddressLabel.Font = new Font("Segoe UI", 10F);
            stationAddressLabel.Location = new Point(12, 151);
            stationAddressLabel.Name = "stationAddressLabel";
            stationAddressLabel.Size = new Size(61, 19);
            stationAddressLabel.TabIndex = 7;
            stationAddressLabel.Text = "Address:";
            // 
            // stationNameLabel
            // 
            stationNameLabel.AutoSize = true;
            stationNameLabel.Font = new Font("Segoe UI", 10F);
            stationNameLabel.Location = new Point(12, 88);
            stationNameLabel.Name = "stationNameLabel";
            stationNameLabel.Size = new Size(48, 19);
            stationNameLabel.TabIndex = 6;
            stationNameLabel.Text = "Name:";
            // 
            // stationCityList
            // 
            stationCityList.DropDownStyle = ComboBoxStyle.DropDownList;
            stationCityList.FormattingEnabled = true;
            stationCityList.Location = new Point(12, 236);
            stationCityList.Name = "stationCityList";
            stationCityList.Size = new Size(200, 23);
            stationCityList.TabIndex = 5;
            // 
            // stationAddressField
            // 
            stationAddressField.Location = new Point(12, 173);
            stationAddressField.Name = "stationAddressField";
            stationAddressField.Size = new Size(200, 23);
            stationAddressField.TabIndex = 4;
            // 
            // stationNameField
            // 
            fieldsErrorProvider.SetIconPadding(stationNameField, 2);
            stationNameField.Location = new Point(12, 110);
            stationNameField.Name = "stationNameField";
            stationNameField.Size = new Size(200, 23);
            stationNameField.TabIndex = 3;
            // 
            // createStationLabel
            // 
            createStationLabel.Anchor = AnchorStyles.None;
            createStationLabel.AutoSize = true;
            createStationLabel.BackColor = SystemColors.ActiveCaption;
            createStationLabel.Font = new Font("Segoe UI", 18.5F);
            createStationLabel.Location = new Point(3, 33);
            createStationLabel.Name = "createStationLabel";
            createStationLabel.Size = new Size(267, 35);
            createStationLabel.TabIndex = 2;
            createStationLabel.Text = "Create new bus station";
            // 
            // stationsTable
            // 
            stationsTable.AutoScroll = true;
            stationsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            stationsTable.ColumnCount = 1;
            stationsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            stationsTable.Location = new Point(274, 33);
            stationsTable.Name = "stationsTable";
            stationsTable.Padding = new Padding(0, 0, 17, 0);
            stationsTable.Size = new Size(530, 414);
            stationsTable.TabIndex = 1;
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(logoutButton);
            navPanel.Controls.Add(manageStationsButton);
            navPanel.Controls.Add(manageSchedulesButton);
            navPanel.Controls.Add(manageAccountsButton);
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(800, 30);
            navPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(713, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 25);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // manageStationsButton
            // 
            manageStationsButton.Anchor = AnchorStyles.None;
            manageStationsButton.BackColor = SystemColors.Control;
            manageStationsButton.Location = new Point(143, 2);
            manageStationsButton.Name = "manageStationsButton";
            manageStationsButton.Size = new Size(125, 25);
            manageStationsButton.TabIndex = 4;
            manageStationsButton.Text = "Manage Stations";
            manageStationsButton.UseVisualStyleBackColor = false;
            // 
            // manageSchedulesButton
            // 
            manageSchedulesButton.Anchor = AnchorStyles.None;
            manageSchedulesButton.Location = new Point(12, 2);
            manageSchedulesButton.Name = "manageSchedulesButton";
            manageSchedulesButton.Size = new Size(125, 25);
            manageSchedulesButton.TabIndex = 3;
            manageSchedulesButton.Text = "Manage Schedules";
            manageSchedulesButton.UseVisualStyleBackColor = true;
            manageSchedulesButton.Click += manageSchedulesButton_Click;
            // 
            // manageAccountsButton
            // 
            manageAccountsButton.Anchor = AnchorStyles.None;
            manageAccountsButton.Location = new Point(274, 2);
            manageAccountsButton.Name = "manageAccountsButton";
            manageAccountsButton.Size = new Size(125, 25);
            manageAccountsButton.TabIndex = 2;
            manageAccountsButton.Text = "Manage Accounts";
            manageAccountsButton.UseVisualStyleBackColor = true;
            // 
            // fieldsErrorProvider
            // 
            fieldsErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            fieldsErrorProvider.ContainerControl = this;
            // 
            // StationManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "StationManager";
            Text = "StationManager";
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fieldsErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel navPanel;
        private Button manageSchedulesButton;
        private Button manageAccountsButton;
        private Button manageStationsButton;
        private TableLayoutPanel stationsTable;
        private Label createStationLabel;
        private ComboBox stationCityList;
        private TextBox stationAddressField;
        private TextBox stationNameField;
        private Button addStationButton;
        private Label stationCityLabel;
        private Label stationAddressLabel;
        private Label stationNameLabel;
        private ErrorProvider fieldsErrorProvider;
        private Button logoutButton;
    }
}