namespace BusManager.Presentation.Views
{
    partial class RegisterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterWindow));
            Panel = new Panel();
            logo = new PictureBox();
            loginButton = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            PasswordField = new TextBox();
            registerButton = new LinkLabel();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(registerButton);
            Panel.Controls.Add(logo);
            Panel.Controls.Add(loginButton);
            Panel.Controls.Add(textBox4);
            Panel.Controls.Add(textBox3);
            Panel.Controls.Add(textBox2);
            Panel.Controls.Add(textBox1);
            Panel.Controls.Add(PasswordField);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 0;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.None;
            logo.ErrorImage = Properties.Resources.Logo;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(212, 10);
            logo.Name = "logo";
            logo.Size = new Size(376, 210);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.Location = new Point(325, 370);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 40);
            loginButton.TabIndex = 7;
            loginButton.Text = "Register";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(325, 340);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.PlaceholderText = "Repeat Password";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(325, 310);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Password";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(325, 280);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(325, 250);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Last Name";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 3;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.None;
            PasswordField.Location = new Point(325, 220);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = "First Name";
            PasswordField.Size = new Size(150, 23);
            PasswordField.TabIndex = 2;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.AutoSize = true;
            registerButton.Location = new Point(339, 413);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(136, 15);
            registerButton.TabIndex = 9;
            registerButton.TabStop = true;
            registerButton.Text = "Have an Account? Login";
            registerButton.LinkClicked += registerButton_LinkClicked;
            // 
            // RegisterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "RegisterWindow";
            Text = "RegisterWindow";
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox PasswordField;
        private Button loginButton;
        private PictureBox logo;
        private LinkLabel registerButton;
    }
}