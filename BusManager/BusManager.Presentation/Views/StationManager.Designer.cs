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
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            Panel.SuspendLayout();
            navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            addStationButton.Click += addStationButton_Click;
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
            errorProvider1.SetIconPadding(stationNameField, 2);
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
            stationsTable.Size = new Size(523, 414);
            stationsTable.TabIndex = 1;
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(button4);
            navPanel.Controls.Add(button1);
            navPanel.Controls.Add(button3);
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(800, 30);
            navPanel.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(143, 2);
            button4.Name = "button4";
            button4.Size = new Size(125, 25);
            button4.TabIndex = 4;
            button4.Text = "Manage Stations";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(12, 2);
            button1.Name = "button1";
            button1.Size = new Size(125, 25);
            button1.TabIndex = 3;
            button1.Text = "Manage Schedules";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(274, 2);
            button3.Name = "button3";
            button3.Size = new Size(125, 25);
            button3.TabIndex = 2;
            button3.Text = "Manage Accounts";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 380);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel navPanel;
        private Button button1;
        private Button button3;
        private Button button4;
        private TableLayoutPanel stationsTable;
        private Label label1;
        private Label createStationLabel;
        private ComboBox stationCityList;
        private TextBox stationAddressField;
        private TextBox stationNameField;
        private Button addStationButton;
        private Label stationCityLabel;
        private Label stationAddressLabel;
        private Label stationNameLabel;
        private ErrorProvider errorProvider1;
    }
}