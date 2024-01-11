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
            Panel = new Panel();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            createStationLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            Panel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(button2);
            Panel.Controls.Add(label4);
            Panel.Controls.Add(label3);
            Panel.Controls.Add(label2);
            Panel.Controls.Add(comboBox1);
            Panel.Controls.Add(textBox2);
            Panel.Controls.Add(textBox1);
            Panel.Controls.Add(createStationLabel);
            Panel.Controls.Add(tableLayoutPanel1);
            Panel.Controls.Add(panel2);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(168, 408);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 9;
            button2.Text = "Add station";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 8;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 7;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Location = new Point(274, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(523, 414);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 0;
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
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label createStationLabel;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}