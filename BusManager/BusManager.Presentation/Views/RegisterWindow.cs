using BusManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using BusManager.Core.Helpers.Exceptions;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Diagnostics;

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
            fieldsErrorProvider.SetError(FirstNameField, string.Empty);
            fieldsErrorProvider.SetError(LastNameField, string.Empty);
            fieldsErrorProvider.SetError(EmailField, string.Empty);
            fieldsErrorProvider.SetError(EmailField, string.Empty);
            fieldsErrorProvider.SetError(PasswordField, string.Empty);
            fieldsErrorProvider.SetError(RepeatPasswordField, string.Empty);
            string fName = FirstNameField.Text;
            string lName = LastNameField.Text;
            string email = EmailField.Text;
            string password = PasswordField.Text;
            string repeatPassword = RepeatPasswordField.Text;
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
                foreach(var ex in errors.InnerExceptions)
                {
                    switch (ex.GetType().Name)
                    {
                        case "InvalidFirstNameException":
                            fieldsErrorProvider.SetError(FirstNameField, ex.Message);
                            break;
                        case "InvalidLastNameException":
                            fieldsErrorProvider.SetError(LastNameField, ex.Message);
                            break;
                        case "InvalidEmailException":
                            fieldsErrorProvider.SetError(EmailField, ex.Message);
                            break;
                        case "EmailInUseException":
                            fieldsErrorProvider.SetError(EmailField, ex.Message);
                            break;
                        case "InvalidPasswordException":
                            fieldsErrorProvider.SetError(PasswordField, ex.Message);
                            break;
                        case "PasswordNotMatchingException":
                            fieldsErrorProvider.SetError(RepeatPasswordField, ex.Message);
                            break;
                        default:
                            MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }
    }

}
