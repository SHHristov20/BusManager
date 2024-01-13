using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using BusManager.Presentation.Properties;
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
            //windowManager.LoadScene(WindowManager.SCENES.BOOK_TICKET);
            // temp
            string email = EmailField.Text;
            string password = PasswordField.Text;
            var userService = WindowManager.Instance.serviceProvider.GetService<IUserService>();
            try
            {
                //bool logged = await userService.Login(email, password);
                User user = await userService.Login(email, password) ?? throw new Exception("Something went wrong!");
                windowManager.LoggedUser = user;
                if (user.UserTypeId == 3)
                {
                    windowManager.LoadScene(WindowManager.SCENES.STATION_MANAGER);
                }
                else windowManager.LoadScene(WindowManager.SCENES.BOOK_TICKET);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
