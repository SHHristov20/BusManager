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
            LoginButton = new LinkLabel();
            Logo = new PictureBox();
            RegisterButton = new Button();
            RepeatPasswordField = new TextBox();
            PasswordField = new TextBox();
            EmailField = new TextBox();
            LastNameField = new TextBox();
            FirstNameField = new TextBox();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.None;
            Panel.Controls.Add(LoginButton);
            Panel.Controls.Add(Logo);
            Panel.Controls.Add(RegisterButton);
            Panel.Controls.Add(RepeatPasswordField);
            Panel.Controls.Add(PasswordField);
            Panel.Controls.Add(EmailField);
            Panel.Controls.Add(LastNameField);
            Panel.Controls.Add(FirstNameField);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(800, 450);
            Panel.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.AutoSize = true;
            LoginButton.Location = new Point(339, 413);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(136, 15);
            LoginButton.TabIndex = 9;
            LoginButton.TabStop = true;
            LoginButton.Text = "Have an Account? Login";
            LoginButton.LinkClicked += LoginButton_LinkClicked;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.ErrorImage = Properties.Resources.Logo;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(212, 10);
            Logo.Name = "Logo";
            Logo.Size = new Size(376, 210);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 8;
            Logo.TabStop = false;
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.None;
            RegisterButton.Location = new Point(325, 370);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 40);
            RegisterButton.TabIndex = 7;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RepeatPasswordField
            // 
            RepeatPasswordField.Anchor = AnchorStyles.None;
            RepeatPasswordField.Location = new Point(325, 340);
            RepeatPasswordField.Name = "RepeatPasswordField";
            RepeatPasswordField.PasswordChar = '*';
            RepeatPasswordField.PlaceholderText = "Repeat Password";
            RepeatPasswordField.Size = new Size(150, 23);
            RepeatPasswordField.TabIndex = 6;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.None;
            PasswordField.Location = new Point(325, 310);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = "Password";
            PasswordField.Size = new Size(150, 23);
            PasswordField.TabIndex = 5;
            // 
            // EmailField
            // 
            EmailField.Anchor = AnchorStyles.None;
            EmailField.Location = new Point(325, 280);
            EmailField.Name = "EmailField";
            EmailField.PlaceholderText = "Email";
            EmailField.Size = new Size(150, 23);
            EmailField.TabIndex = 4;
            // 
            // LastNameField
            // 
            LastNameField.Anchor = AnchorStyles.None;
            LastNameField.Location = new Point(325, 250);
            LastNameField.Name = "LastNameField";
            LastNameField.PlaceholderText = "Last Name";
            LastNameField.Size = new Size(150, 23);
            LastNameField.TabIndex = 3;
            // 
            // FirstNameField
            // 
            FirstNameField.Anchor = AnchorStyles.None;
            FirstNameField.Location = new Point(325, 220);
            FirstNameField.Name = "FirstNameField";
            FirstNameField.PlaceholderText = "First Name";
            FirstNameField.Size = new Size(150, 23);
            FirstNameField.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private TextBox RepeatPasswordField;
        private TextBox PasswordField;
        private TextBox EmailField;
        private TextBox LastNameField;
        private TextBox FirstNameField;
        private Button RegisterButton;
        private PictureBox Logo;
        private LinkLabel LoginButton;
    }
}