using BusManager.Core.Implementations;
using BusManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var userService = WindowManager.Instance.serviceProvider.GetService<IUserService>();
            try
            {
                bool a = await userService.Register(fName, lName, email, password, repeatPassword);
                MessageBox.Show(a.ToString());

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
