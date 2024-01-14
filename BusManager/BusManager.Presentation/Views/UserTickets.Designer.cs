namespace BusManager.Presentation.Views
{
    partial class UserTickets
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
            Panel = new Panel();
            ticketInfo = new Panel();
            qrCodeImage = new PictureBox();
            timeLabel = new Label();
            dateLabel = new Label();
            emailLabel = new Label();
            nameLabel = new Label();
            stationsLabel = new Label();
            citiesLabel = new Label();
            ticketLabel = new Label();
            navPanel = new Panel();
            bookTicketButton = new Button();
            logoutButton = new Button();
            ticketsTable = new TableLayoutPanel();
            Panel.SuspendLayout();
            ticketInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrCodeImage).BeginInit();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(ticketInfo);
            Panel.Controls.Add(navPanel);
            Panel.Controls.Add(ticketsTable);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 0;
            // 
            // ticketInfo
            // 
            ticketInfo.BackColor = Color.LightGray;
            ticketInfo.Controls.Add(qrCodeImage);
            ticketInfo.Controls.Add(timeLabel);
            ticketInfo.Controls.Add(dateLabel);
            ticketInfo.Controls.Add(emailLabel);
            ticketInfo.Controls.Add(nameLabel);
            ticketInfo.Controls.Add(stationsLabel);
            ticketInfo.Controls.Add(citiesLabel);
            ticketInfo.Controls.Add(ticketLabel);
            ticketInfo.Location = new Point(469, 30);
            ticketInfo.Name = "ticketInfo";
            ticketInfo.Size = new Size(331, 420);
            ticketInfo.TabIndex = 12;
            // 
            // qrCodeImage
            // 
            qrCodeImage.Location = new Point(14, 264);
            qrCodeImage.Name = "qrCodeImage";
            qrCodeImage.Size = new Size(150, 150);
            qrCodeImage.TabIndex = 8;
            qrCodeImage.TabStop = false;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 12F);
            timeLabel.Location = new Point(14, 160);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(121, 21);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Departure Time:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F);
            dateLabel.Location = new Point(14, 120);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(119, 21);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Departure Date:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F);
            emailLabel.Location = new Point(14, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 21);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F);
            nameLabel.Location = new Point(14, 200);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(55, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // stationsLabel
            // 
            stationsLabel.AutoSize = true;
            stationsLabel.Font = new Font("Segoe UI", 12F);
            stationsLabel.Location = new Point(14, 80);
            stationsLabel.Name = "stationsLabel";
            stationsLabel.Size = new Size(68, 21);
            stationsLabel.TabIndex = 3;
            stationsLabel.Text = "Stations:";
            // 
            // citiesLabel
            // 
            citiesLabel.AutoSize = true;
            citiesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            citiesLabel.Location = new Point(158, 33);
            citiesLabel.Name = "citiesLabel";
            citiesLabel.Size = new Size(20, 28);
            citiesLabel.TabIndex = 2;
            citiesLabel.Text = "-";
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
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(bookTicketButton);
            navPanel.Controls.Add(logoutButton);
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(800, 30);
            navPanel.TabIndex = 11;
            // 
            // bookTicketButton
            // 
            bookTicketButton.Location = new Point(12, 2);
            bookTicketButton.Name = "bookTicketButton";
            bookTicketButton.Size = new Size(103, 25);
            bookTicketButton.TabIndex = 6;
            bookTicketButton.Text = "Book a ticket";
            bookTicketButton.UseVisualStyleBackColor = true;
            bookTicketButton.Click += bookTicketButton_Click;
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
            // ticketsTable
            // 
            ticketsTable.AutoScroll = true;
            ticketsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ticketsTable.ColumnCount = 1;
            ticketsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ticketsTable.Location = new Point(0, 30);
            ticketsTable.Name = "ticketsTable";
            ticketsTable.Padding = new Padding(0, 0, 17, 0);
            ticketsTable.Size = new Size(463, 420);
            ticketsTable.TabIndex = 13;
            // 
            // UserTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "UserTickets";
            Text = "UserTickets";
            Panel.ResumeLayout(false);
            ticketInfo.ResumeLayout(false);
            ticketInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qrCodeImage).EndInit();
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel navPanel;
        private Button logoutButton;
        private Panel ticketInfo;
        private Label timeLabel;
        private Label dateLabel;
        private Label emailLabel;
        private Label nameLabel;
        private Label stationsLabel;
        private Label citiesLabel;
        private Label ticketLabel;
        private Button bookTicketButton;
        private TableLayoutPanel ticketsTable;
        private PictureBox qrCodeImage;
    }
}