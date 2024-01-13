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
            components = new System.ComponentModel.Container();
            Panel = new Panel();
            panel1 = new Panel();
            toList = new ComboBox();
            departureLabel = new Label();
            datePicker = new DateTimePicker();
            searchButton = new Button();
            toLabel = new Label();
            fromList = new ComboBox();
            logoutButton = new Button();
            button2 = new Button();
            fromLabel = new Label();
            button3 = new Button();
            button4 = new Button();
            schedulesTable = new TableLayoutPanel();
            fieldsErrorProvider = new ErrorProvider(components);
            Panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fieldsErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(panel1);
            Panel.Controls.Add(schedulesTable);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(toList);
            panel1.Controls.Add(departureLabel);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(toLabel);
            panel1.Controls.Add(fromList);
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(fromLabel);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 10;
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
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(443, -33);
            button2.Name = "button2";
            button2.Size = new Size(125, 25);
            button2.TabIndex = 4;
            button2.Text = "Manage Stations";
            button2.UseVisualStyleBackColor = false;
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
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(312, -33);
            button3.Name = "button3";
            button3.Size = new Size(125, 25);
            button3.TabIndex = 3;
            button3.Text = "Manage Schedules";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(574, -33);
            button4.Name = "button4";
            button4.Size = new Size(125, 25);
            button4.TabIndex = 2;
            button4.Text = "Manage Accounts";
            button4.UseVisualStyleBackColor = true;
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
            // fieldsErrorProvider
            // 
            fieldsErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            fieldsErrorProvider.ContainerControl = this;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fieldsErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Label fromLabel;
        private ErrorProvider fieldsErrorProvider;
        private TableLayoutPanel schedulesTable;
        private Panel panel1;
        private Label toLabel;
        private ComboBox fromList;
        private Button logoutButton;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button searchButton;
        private DateTimePicker datePicker;
        private Label departureLabel;
        private ComboBox toList;
    }
}