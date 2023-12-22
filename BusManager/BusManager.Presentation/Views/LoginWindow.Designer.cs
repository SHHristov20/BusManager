using System.Windows.Forms;

namespace BusManager.Presentation
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            LoginButton = new Button();
            PasswordField = new TextBox();
            EmailField = new TextBox();
            Logo = new PictureBox();
            RegisterButton = new LinkLabel();
            Panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.Location = new Point(325, 340);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 40);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.None;
            PasswordField.Location = new Point(325, 305);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = "Password";
            PasswordField.Size = new Size(150, 23);
            PasswordField.TabIndex = 1;
            // 
            // EmailField
            // 
            EmailField.Anchor = AnchorStyles.None;
            EmailField.Location = new Point(325, 275);
            EmailField.Name = "EmailField";
            EmailField.PlaceholderText = "Email";
            EmailField.Size = new Size(150, 23);
            EmailField.TabIndex = 2;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.ErrorImage = Properties.Resources.Logo;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(212, 20);
            Logo.Name = "Logo";
            Logo.Size = new Size(376, 210);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.None;
            RegisterButton.AutoSize = true;
            RegisterButton.Location = new Point(354, 383);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(121, 15);
            RegisterButton.TabIndex = 4;
            RegisterButton.TabStop = true;
            RegisterButton.Text = "No Account? Register";
            RegisterButton.LinkClicked += RegisterButton_LinkClicked;
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(Logo);
            Panel.Controls.Add(LoginButton);
            Panel.Controls.Add(PasswordField);
            Panel.Controls.Add(RegisterButton);
            Panel.Controls.Add(EmailField);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 5;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel);
            Name = "LoginWindow";
            Text = "Bus Manager";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private TextBox PasswordField;
        private TextBox EmailField;
        private PictureBox Logo;
        private LinkLabel RegisterButton;
        private Panel Panel;
    }
}
