using BusManager.Presentation.Properties;
using Microsoft.VisualBasic.Logging;
using BusManager;
namespace BusManager.Presentation.Views
{
    partial class TicketValidator
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
            ticketCodeLabel = new Label();
            logo = new PictureBox();
            checkTicketButton = new Button();
            ticketCodeField = new TextBox();
            ticketInfo = new Panel();
            timeLabel = new Label();
            dateLabel = new Label();
            emailLabel = new Label();
            nameLabel = new Label();
            stationsLabel = new Label();
            citiesLabel = new Label();
            ticketLabel = new Label();
            statusPanel = new Panel();
            statusLabel = new Label();
            navPanel = new Panel();
            logoutButton = new Button();
            fieldErrorProvider = new ErrorProvider(components);
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ticketInfo.SuspendLayout();
            statusPanel.SuspendLayout();
            navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fieldErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(ticketCodeLabel);
            Panel.Controls.Add(logo);
            Panel.Controls.Add(checkTicketButton);
            Panel.Controls.Add(ticketCodeField);
            Panel.Controls.Add(ticketInfo);
            Panel.Controls.Add(navPanel);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 0;
            // 
            // ticketCodeLabel
            // 
            ticketCodeLabel.AutoSize = true;
            ticketCodeLabel.Font = new Font("Segoe UI", 12F);
            ticketCodeLabel.Location = new Point(12, 306);
            ticketCodeLabel.Name = "ticketCodeLabel";
            ticketCodeLabel.Size = new Size(127, 21);
            ticketCodeLabel.TabIndex = 5;
            ticketCodeLabel.Text = "Enter ticket code:";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(3, 30);
            logo.Name = "logo";
            logo.Size = new Size(463, 256);
            logo.TabIndex = 4;
            logo.TabStop = false;
            // 
            // checkTicketButton
            // 
            checkTicketButton.Font = new Font("Segoe UI", 12F);
            checkTicketButton.Location = new Point(50, 359);
            checkTicketButton.Name = "checkTicketButton";
            checkTicketButton.Size = new Size(105, 30);
            checkTicketButton.TabIndex = 3;
            checkTicketButton.Text = "Check Ticket";
            checkTicketButton.UseVisualStyleBackColor = true;
            checkTicketButton.Click += checkTicketButton_Click;
            // 
            // ticketCodeField
            // 
            ticketCodeField.Location = new Point(12, 330);
            ticketCodeField.Name = "ticketCodeField";
            ticketCodeField.Size = new Size(143, 23);
            ticketCodeField.TabIndex = 2;
            ticketCodeField.KeyDown += ticketCodeField_KeyDown;
            // 
            // ticketInfo
            // 
            ticketInfo.BackColor = Color.LightGray;
            ticketInfo.Controls.Add(timeLabel);
            ticketInfo.Controls.Add(dateLabel);
            ticketInfo.Controls.Add(emailLabel);
            ticketInfo.Controls.Add(nameLabel);
            ticketInfo.Controls.Add(stationsLabel);
            ticketInfo.Controls.Add(citiesLabel);
            ticketInfo.Controls.Add(ticketLabel);
            ticketInfo.Controls.Add(statusPanel);
            ticketInfo.Location = new Point(469, 30);
            ticketInfo.Name = "ticketInfo";
            ticketInfo.Size = new Size(331, 420);
            ticketInfo.TabIndex = 0;
            ticketInfo.Paint += ticketInfo_Paint;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 12F);
            timeLabel.Location = new Point(14, 160);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(164, 21);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Departure Time: 12:03";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F);
            dateLabel.Location = new Point(14, 120);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(207, 21);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Departure Date: 12/01/2024";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F);
            emailLabel.Location = new Point(14, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(140, 21);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email: asd@abv.bg";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F);
            nameLabel.Location = new Point(14, 200);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(156, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name: Stefan Hristov";
            // 
            // stationsLabel
            // 
            stationsLabel.AutoSize = true;
            stationsLabel.Font = new Font("Segoe UI", 12F);
            stationsLabel.Location = new Point(14, 80);
            stationsLabel.Name = "stationsLabel";
            stationsLabel.Size = new Size(134, 21);
            stationsLabel.TabIndex = 3;
            stationsLabel.Text = "Stations: asd - asd";
            // 
            // citiesLabel
            // 
            citiesLabel.AutoSize = true;
            citiesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            citiesLabel.Location = new Point(83, 33);
            citiesLabel.Name = "citiesLabel";
            citiesLabel.Size = new Size(150, 28);
            citiesLabel.TabIndex = 2;
            citiesLabel.Text = "Burgas - Varna";
            // 
            // ticketLabel
            // 
            ticketLabel.AutoSize = true;
            ticketLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ticketLabel.Location = new Point(14, 3);
            ticketLabel.Name = "ticketLabel";
            ticketLabel.Size = new Size(305, 30);
            ticketLabel.TabIndex = 1;
            ticketLabel.Text = "Ticket - 0000000000000000";
            // 
            // statusPanel
            // 
            statusPanel.BackColor = SystemColors.ControlDarkDark;
            statusPanel.Controls.Add(statusLabel);
            statusPanel.Location = new Point(0, 348);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(340, 72);
            statusPanel.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            statusLabel.ForeColor = SystemColors.Control;
            statusLabel.Location = new Point(-8, 7);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(348, 65);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "ENTER TICKET";
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(logoutButton);
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(800, 30);
            navPanel.TabIndex = 1;
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
            // fieldErrorProvider
            // 
            fieldErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            fieldErrorProvider.ContainerControl = this;
            // 
            // TicketValidator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "TicketValidator";
            Text = "TicketValidator";
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ticketInfo.ResumeLayout(false);
            ticketInfo.PerformLayout();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fieldErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel ticketInfo;
        private Panel navPanel;
        private Button logoutButton;
        private Panel statusPanel;
        private Label statusLabel;
        private Label dateLabel;
        private Label emailLabel;
        private Label nameLabel;
        private Label stationsLabel;
        private Label citiesLabel;
        private Label ticketLabel;
        private Label timeLabel;
        private Button checkTicketButton;
        private TextBox ticketCodeField;
        private PictureBox logo;
        private Label ticketCodeLabel;
        private ErrorProvider fieldErrorProvider;
    }
}