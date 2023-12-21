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
            loginField = new Button();
            PasswordField = new TextBox();
            emailField = new TextBox();
            logo = new PictureBox();
            registerButton = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.None;
            loginField.Location = new Point(325, 340);
            loginField.Name = "loginField";
            loginField.Size = new Size(150, 40);
            loginField.TabIndex = 0;
            loginField.Text = "Login";
            loginField.UseVisualStyleBackColor = true;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.None;
            PasswordField.Location = new Point(325, 298);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = "Password";
            PasswordField.Size = new Size(150, 23);
            PasswordField.TabIndex = 1;
            // 
            // emailField
            // 
            emailField.Anchor = AnchorStyles.None;
            emailField.Location = new Point(325, 257);
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
            logo.Location = new Point(212, 2);
            logo.Name = "logo";
            logo.Size = new Size(376, 210);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.AutoSize = true;
            registerButton.Location = new Point(354, 383);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(121, 15);
            registerButton.TabIndex = 4;
            registerButton.TabStop = true;
            registerButton.Text = "No Account? Register";
            registerButton.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(logo);
            Controls.Add(emailField);
            Controls.Add(PasswordField);
            Controls.Add(loginField);
            Name = "LoginWindow";
            Text = "Bus Manager";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginField;
        private TextBox PasswordField;
        private TextBox emailField;
        private PictureBox logo;
        private LinkLabel registerButton;
    }
}
