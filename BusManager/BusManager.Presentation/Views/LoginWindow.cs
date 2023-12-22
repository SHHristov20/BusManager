using BusManager.Presentation.Views;

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

        private void registerButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoadScene(WindowManager.SCENES.REGISTER);
        }
    }
}
