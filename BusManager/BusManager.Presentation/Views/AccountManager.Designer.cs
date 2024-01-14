namespace BusManager.Presentation.Views
{
    partial class AccountManager
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
            usersTable = new TableLayoutPanel();
            navPanel = new Panel();
            logoutButton = new Button();
            manageAccountsButton = new Button();
            manageSchedulesButton = new Button();
            manageStationsButton = new Button();
            Panel.SuspendLayout();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(usersTable);
            Panel.Controls.Add(navPanel);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 0;
            // 
            // usersTable
            // 
            usersTable.AutoScroll = true;
            usersTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            usersTable.ColumnCount = 1;
            usersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            usersTable.Location = new Point(3, 33);
            usersTable.Name = "usersTable";
            usersTable.Padding = new Padding(0, 0, 17, 0);
            usersTable.Size = new Size(800, 414);
            usersTable.TabIndex = 2;
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(logoutButton);
            navPanel.Controls.Add(manageAccountsButton);
            navPanel.Controls.Add(manageSchedulesButton);
            navPanel.Controls.Add(manageStationsButton);
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
            // manageAccountsButton
            // 
            manageAccountsButton.Anchor = AnchorStyles.None;
            manageAccountsButton.BackColor = SystemColors.Control;
            manageAccountsButton.Location = new Point(274, 2);
            manageAccountsButton.Name = "manageAccountsButton";
            manageAccountsButton.Size = new Size(125, 25);
            manageAccountsButton.TabIndex = 4;
            manageAccountsButton.Text = "Manage Accounts";
            manageAccountsButton.UseVisualStyleBackColor = false;
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
            // manageStationsButton
            // 
            manageStationsButton.Anchor = AnchorStyles.None;
            manageStationsButton.Location = new Point(143, 2);
            manageStationsButton.Name = "manageStationsButton";
            manageStationsButton.Size = new Size(125, 25);
            manageStationsButton.TabIndex = 2;
            manageStationsButton.Text = "Manage Stations";
            manageStationsButton.UseVisualStyleBackColor = true;
            manageStationsButton.Click += manageStationsButton_Click;
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "AccountManager";
            Text = "AccountManager";
            Panel.ResumeLayout(false);
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel navPanel;
        private Button logoutButton;
        private Button manageAccountsButton;
        private Button manageSchedulesButton;
        private Button manageStationsButton;
        private TableLayoutPanel usersTable;
    }
}