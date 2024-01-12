namespace BusManager.Presentation.Views
{
    partial class ScheduleManager
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
            priceLabel = new Label();
            fromList = new ComboBox();
            datePicker = new DateTimePicker();
            addScheduleButton = new Button();
            dateLabel = new Label();
            toLabel = new Label();
            fromLabel = new Label();
            toList = new ComboBox();
            priceField = new TextBox();
            createStationLabel = new Label();
            schedulesTable = new TableLayoutPanel();
            navPanel = new Panel();
            logoutButton = new Button();
            manageSchedulesButton = new Button();
            manageStationsButton = new Button();
            manageAccountsButton = new Button();
            label1 = new Label();
            fieldsErrorProvider = new ErrorProvider(components);
            Panel.SuspendLayout();
            navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fieldsErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(priceLabel);
            Panel.Controls.Add(fromList);
            Panel.Controls.Add(datePicker);
            Panel.Controls.Add(addScheduleButton);
            Panel.Controls.Add(dateLabel);
            Panel.Controls.Add(toLabel);
            Panel.Controls.Add(fromLabel);
            Panel.Controls.Add(toList);
            Panel.Controls.Add(priceField);
            Panel.Controls.Add(createStationLabel);
            Panel.Controls.Add(schedulesTable);
            Panel.Controls.Add(navPanel);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 10F);
            priceLabel.ForeColor = SystemColors.ControlText;
            priceLabel.Location = new Point(12, 277);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 19);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            // 
            // fromList
            // 
            fromList.DropDownStyle = ComboBoxStyle.DropDownList;
            fromList.FormattingEnabled = true;
            fromList.Location = new Point(12, 110);
            fromList.Name = "fromList";
            fromList.Size = new Size(200, 23);
            fromList.TabIndex = 11;
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "HH:mm dd/MM/yyyy";
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(12, 236);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 10;
            // 
            // addScheduleButton
            // 
            addScheduleButton.Location = new Point(168, 408);
            addScheduleButton.Name = "addScheduleButton";
            addScheduleButton.Size = new Size(100, 30);
            addScheduleButton.TabIndex = 9;
            addScheduleButton.Text = "Add schedule";
            addScheduleButton.UseVisualStyleBackColor = true;
            addScheduleButton.Click += addScheduleButton_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10F);
            dateLabel.ForeColor = SystemColors.ControlText;
            dateLabel.Location = new Point(12, 214);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(41, 19);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Font = new Font("Segoe UI", 10F);
            toLabel.Location = new Point(12, 151);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(26, 19);
            toLabel.TabIndex = 7;
            toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Font = new Font("Segoe UI", 10F);
            fromLabel.Location = new Point(12, 88);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(44, 19);
            fromLabel.TabIndex = 6;
            fromLabel.Text = "From:";
            // 
            // toList
            // 
            toList.DropDownStyle = ComboBoxStyle.DropDownList;
            toList.FormattingEnabled = true;
            toList.Location = new Point(12, 173);
            toList.Name = "toList";
            toList.Size = new Size(200, 23);
            toList.TabIndex = 5;
            // 
            // priceField
            // 
            priceField.Location = new Point(12, 299);
            priceField.Name = "priceField";
            priceField.Size = new Size(200, 23);
            priceField.TabIndex = 4;
            priceField.KeyPress += priceField_KeyPress;
            // 
            // createStationLabel
            // 
            createStationLabel.Anchor = AnchorStyles.None;
            createStationLabel.AutoSize = true;
            createStationLabel.BackColor = SystemColors.ActiveCaption;
            createStationLabel.Font = new Font("Segoe UI", 20F);
            createStationLabel.Location = new Point(7, 33);
            createStationLabel.Name = "createStationLabel";
            createStationLabel.Size = new Size(261, 37);
            createStationLabel.TabIndex = 2;
            createStationLabel.Text = "Create new schedule";
            // 
            // schedulesTable
            // 
            schedulesTable.AutoScroll = true;
            schedulesTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            schedulesTable.ColumnCount = 1;
            schedulesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            schedulesTable.Location = new Point(274, 33);
            schedulesTable.Name = "schedulesTable";
            schedulesTable.Padding = new Padding(0, 0, 17, 0);
            schedulesTable.Size = new Size(530, 414);
            schedulesTable.TabIndex = 1;
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.None;
            navPanel.BackColor = SystemColors.AppWorkspace;
            navPanel.Controls.Add(logoutButton);
            navPanel.Controls.Add(manageSchedulesButton);
            navPanel.Controls.Add(manageStationsButton);
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
            // manageSchedulesButton
            // 
            manageSchedulesButton.Anchor = AnchorStyles.None;
            manageSchedulesButton.BackColor = SystemColors.Control;
            manageSchedulesButton.Location = new Point(12, 2);
            manageSchedulesButton.Name = "manageSchedulesButton";
            manageSchedulesButton.Size = new Size(125, 25);
            manageSchedulesButton.TabIndex = 4;
            manageSchedulesButton.Text = "Manage Schedules";
            manageSchedulesButton.UseVisualStyleBackColor = false;
            // 
            // manageStationsButton
            // 
            manageStationsButton.Anchor = AnchorStyles.None;
            manageStationsButton.Location = new Point(143, 2);
            manageStationsButton.Name = "manageStationsButton";
            manageStationsButton.Size = new Size(125, 25);
            manageStationsButton.TabIndex = 3;
            manageStationsButton.Text = "Manage Stations";
            manageStationsButton.UseVisualStyleBackColor = true;
            manageStationsButton.Click += manageStationsButton_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 380);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // fieldsErrorProvider
            // 
            fieldsErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            fieldsErrorProvider.ContainerControl = this;
            // 
            // ScheduleManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "ScheduleManager";
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
        private Button manageStationsButton;
        private Button manageAccountsButton;
        private Button manageSchedulesButton;
        private TableLayoutPanel schedulesTable;
        private Label label1;
        private Label createStationLabel;
        private ComboBox toList;
        private TextBox priceField;
        private Button addScheduleButton;
        private Label dateLabel;
        private Label toLabel;
        private Label fromLabel;
        private ErrorProvider fieldsErrorProvider;
        private Button logoutButton;
        private Label priceLabel;
        private ComboBox fromList;
        private DateTimePicker datePicker;
    }
}