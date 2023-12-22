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
            loginButton = new Button();
            PasswordField = new TextBox();
            emailField = new TextBox();
            logo = new PictureBox();
            registerButton = new LinkLabel();
            Panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.Location = new Point(325, 340);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 40);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
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
            // emailField
            // 
            emailField.Anchor = AnchorStyles.None;
            emailField.Location = new Point(325, 275);
            emailField.Name = "emailField";
            emailField.PlaceholderText = "Email";
            emailField.Size = new Size(150, 23);
            emailField.TabIndex = 2;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.None;
            logo.ErrorImage = Properties.Resources.Logo;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(212, 20);
            logo.Name = "logo";
            logo.Size = new Size(376, 210);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.AutoSize = true;
            registerButton.Location = new Point(354, 383);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(121, 15);
            registerButton.TabIndex = 4;
            registerButton.TabStop = true;
            registerButton.Text = "No Account? Register";
            registerButton.LinkClicked += registerButton_LinkClicked;
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(logo);
            Panel.Controls.Add(loginButton);
            Panel.Controls.Add(PasswordField);
            Panel.Controls.Add(registerButton);
            Panel.Controls.Add(emailField);
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
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private TextBox PasswordField;
        private TextBox emailField;
        private PictureBox logo;
        private LinkLabel registerButton;
        private Panel Panel;
    }
}
