using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManager.Presentation.Views
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            return this.Panel;
        }
        private void manageSchedulesButton_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.LoadScene(WindowManager.SCENES.SCHEDULE_MANAGER);
        }

        private void manageStationsButton_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.LoadScene(WindowManager.SCENES.STATION_MANAGER);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            WindowManager windowManager = WindowManager.Instance;
            windowManager.LoggedUser = null;
            windowManager.LoadScene(WindowManager.SCENES.LOGIN);
        }
    }
}
