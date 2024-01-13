namespace BusManager.Presentation.Views
{
    partial class BookTicket
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
            navPanel = new Panel();
            toList = new ComboBox();
            departureLabel = new Label();
            datePicker = new DateTimePicker();
            searchButton = new Button();
            toLabel = new Label();
            fromList = new ComboBox();
            logoutButton = new Button();
            fromLabel = new Label();
            schedulesTable = new TableLayoutPanel();
            Panel.SuspendLayout();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(navPanel);
            Panel.Controls.Add(schedulesTable);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 2;
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(toList);
            navPanel.Controls.Add(departureLabel);
            navPanel.Controls.Add(datePicker);
            navPanel.Controls.Add(searchButton);
            navPanel.Controls.Add(toLabel);
            navPanel.Controls.Add(fromList);
            navPanel.Controls.Add(logoutButton);
            navPanel.Controls.Add(fromLabel);
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(800, 30);
            navPanel.TabIndex = 10;
            // 
            // toList
            // 
            toList.DropDownStyle = ComboBoxStyle.DropDownList;
            toList.FormattingEnabled = true;
            toList.Location = new Point(204, 3);
            toList.Name = "toList";
            toList.Size = new Size(130, 23);
            toList.TabIndex = 12;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Font = new Font("Segoe UI", 10F);
            departureLabel.Location = new Point(340, 4);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(74, 19);
            departureLabel.TabIndex = 11;
            departureLabel.Text = "Departure:";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(411, 3);
            datePicker.MinDate = new DateTime(2024, 1, 13, 19, 7, 51, 319);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(95, 23);
            datePicker.TabIndex = 10;
            datePicker.Value = new DateTime(2024, 1, 13, 19, 7, 51, 319);
            // 
            // searchButton
            // 
            searchButton.Location = new Point(512, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Font = new Font("Segoe UI", 10F);
            toLabel.Location = new Point(181, 4);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(26, 19);
            toLabel.TabIndex = 8;
            toLabel.Text = "To:";
            // 
            // fromList
            // 
            fromList.DropDownStyle = ComboBoxStyle.DropDownList;
            fromList.FormattingEnabled = true;
            fromList.Location = new Point(45, 3);
            fromList.Name = "fromList";
            fromList.Size = new Size(130, 23);
            fromList.TabIndex = 6;
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
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Font = new Font("Segoe UI", 10F);
            fromLabel.Location = new Point(4, 5);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(44, 19);
            fromLabel.TabIndex = 6;
            fromLabel.Text = "From:";
            // 
            // schedulesTable
            // 
            schedulesTable.AutoScroll = true;
            schedulesTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            schedulesTable.ColumnCount = 1;
            schedulesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            schedulesTable.Location = new Point(4, 33);
            schedulesTable.Name = "schedulesTable";
            schedulesTable.Padding = new Padding(0, 0, 17, 0);
            schedulesTable.Size = new Size(800, 414);
            schedulesTable.TabIndex = 1;
            // 
            // BookTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "BookTicket";
            Text = "BookTicket";
            Panel.ResumeLayout(false);
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Label fromLabel;
        private TableLayoutPanel schedulesTable;
        private Panel navPanel;
        private Label toLabel;
        private ComboBox fromList;
        private Button logoutButton;
        private Button searchButton;
        private DateTimePicker datePicker;
        private Label departureLabel;
        private ComboBox toList;
    }
}