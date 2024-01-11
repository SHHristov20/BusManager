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
            panel1 = new Panel();
            NavPanel = new Panel();
            ToList = new ComboBox();
            FromList = new ComboBox();
            panel1.SuspendLayout();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(NavPanel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // NavPanel
            // 
            NavPanel.BackColor = SystemColors.AppWorkspace;
            NavPanel.Controls.Add(ToList);
            NavPanel.Controls.Add(FromList);
            NavPanel.Location = new Point(0, 0);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(800, 30);
            NavPanel.TabIndex = 1;
            // 
            // ToList
            // 
            ToList.FormattingEnabled = true;
            ToList.Location = new Point(379, 3);
            ToList.Name = "ToList";
            ToList.Size = new Size(121, 23);
            ToList.TabIndex = 1;
            // 
            // FromList
            // 
            FromList.FormattingEnabled = true;
            FromList.Location = new Point(103, 3);
            FromList.Name = "FromList";
            FromList.Size = new Size(121, 23);
            FromList.TabIndex = 0;
            // 
            // BookTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "BookTicket";
            Text = "BookTicket";
            panel1.ResumeLayout(false);
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel NavPanel;
        private ComboBox ToList;
        private ComboBox FromList;
    }
}