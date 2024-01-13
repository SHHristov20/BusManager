using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using BusManager.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;

namespace BusManager.Presentation
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            return Panel;
        }

        private void RegisterButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoadScene(WindowManager.SCENES.REGISTER);
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            // temp
            WindowManager windowManager = WindowManager.Instance;
            // windowManager.LoadScene(WindowManager.SCENES.TICKET_VALIDATOR);
            // temp
            string email = EmailField.Text;
            string password = PasswordField.Text;
            var userService = WindowManager.Instance.serviceProvider.GetService<IUserService>();
            try
            {
                User user = await userService.Login(email, password) ?? throw new Exception("Something went wrong!");
                windowManager.LoggedUser = user;
                WindowManager.USER_TYPES userType = (WindowManager.USER_TYPES)user.UserTypeId;
                switch(userType)
                {
                    case WindowManager.USER_TYPES.USER:
                        windowManager.LoadScene(WindowManager.SCENES.BOOK_TICKET);
                        break;
                    case WindowManager.USER_TYPES.STAFF:
                        windowManager.LoadScene(WindowManager.SCENES.TICKET_VALIDATOR);
                        break;
                    case WindowManager.USER_TYPES.ADMIN:
                        windowManager.LoadScene(WindowManager.SCENES.SCHEDULE_MANAGER);
                        break;
                    default:
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
