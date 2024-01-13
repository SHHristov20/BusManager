﻿using BusManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusManager.Presentation.Views
{
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return this.Panel;
        }

        private void LoginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }

        private async void RegisterButton_ClickAsync(object sender, EventArgs e)
        {
            string fName = FirstNameField.Text;
            string lName = LastNameField.Text;
            string email = EmailField.Text;
            string password = PasswordField.Text;
            string repeatPassword = RepeatPasswordField.Text;
            //UserService userService = new();
            WindowManager windowManager = WindowManager.Instance;
            var userService = windowManager.serviceProvider.GetService<IUserService>();
            try
            {
                bool registered = await userService.Register(fName, lName, email, password, repeatPassword);
                if (registered)
                {
                    windowManager.LoggedUser = await userService.Login(email, password);
                    windowManager.LoadScene(WindowManager.SCENES.BOOK_TICKET);
                }


            }
            catch (AggregateException errors)
            {
                string errorMessage = "";

                foreach(Exception error in errors.InnerExceptions)
                {
                    errorMessage += "- " + error.Message + '\n';
                }
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
