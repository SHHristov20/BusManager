using BusManager.Core.Interfaces;
using BusManager.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
            LoadSchedulesTable();
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
        private async void LoadSchedulesTable()
        {
            usersTable.Controls.Clear();
            foreach (Control c in usersTable.Controls) c.Dispose();
            var userService = WindowManager.Instance.serviceProvider.GetService<IUserService>();
            List<Data.Models.User> users = await userService.GetAllUsers();
            Debug.WriteLine("asdsad");
            for (int i = 0; i < users.Count; i++)
            {
                Label id = new();
                Label email = new();
                Label name = new();
                Label role = new();
                Panel panel = new();
                Button promote = new();
                Button demote = new();
                Button delete = new();
                panel.Height = 30;
                panel.Width = 770;
                id.Text = users[i].Id.ToString();
                id.Anchor = AnchorStyles.None;
                id.Location = new Point(5, 5);
                id.AutoSize = true;
                email.Text = users[i].Email;
                email.Anchor = AnchorStyles.None;
                email.Location = new Point(70, 5);
                name.Text = $"{users[i].FirstName} {users[i].LastName}";
                name.Anchor = AnchorStyles.None;
                name.Location = new Point(270, 5);
                name.AutoSize = true;
                role.Text = users[i].UserType.Name;
                role.Anchor = AnchorStyles.None;
                role.Location = new Point(440, 5);
                role.AutoSize = true;
                promote.Text = "Promote";
                promote.Anchor = AnchorStyles.None;
                promote.Location = new Point(510, 0);
                promote.AutoSize = true;
                demote.Text = "Demote";
                demote.Anchor = AnchorStyles.None;
                demote.Location = new Point(590, 0);
                demote.AutoSize = true;
                delete.Text = "Delete";
                delete.Anchor = AnchorStyles.None;
                delete.Location = new Point(670, 0);
                delete.AutoSize = true;
                if (users[i].UserTypeId == (int)WindowManager.USER_TYPES.USER) demote.Enabled = false;
                if (users[i].UserTypeId == (int)WindowManager.USER_TYPES.ADMIN) promote.Enabled = false;
                if (users[i] == WindowManager.Instance.LoggedUser)
                {
                    delete.Enabled = false;
                    demote.Enabled = false;
                }
                if (users[i].Id == 1)
                {
                    demote.Enabled = false;
                    delete.Enabled = false;
                }
                panel.Controls.AddRange([id, email, name, role, promote, demote, delete]);
                this.usersTable.Controls.Add(panel, 0, i);
                int userIndex = i;
                promote.Click += (sender, e) => PromoteUser(users[userIndex]);
                demote.Click += (sender, e) => DemoteUser(users[userIndex]);
                delete.Click += (sender, e) => DeleteUser(users[userIndex], panel);
            }
            usersTable.PerformLayout();
        }
        private async void PromoteUser(Data.Models.User user)
        {
            WindowManager windowManager = WindowManager.Instance;
            var userService = windowManager.serviceProvider.GetService<IUserService>();
            bool success = true;
            switch ((WindowManager.USER_TYPES)user.UserTypeId)
            {
                case WindowManager.USER_TYPES.USER:
                    if (!await userService.ChangeUserType(user, (int)WindowManager.USER_TYPES.STAFF)) success = false;
                    else LoadSchedulesTable();
                    break;
                case WindowManager.USER_TYPES.STAFF:
                    if (!await userService.ChangeUserType(user, (int)WindowManager.USER_TYPES.ADMIN)) success = false;
                    else LoadSchedulesTable();
                    break;
                default:
                    success = false;
                    break;
            }
            if(!success) MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void DemoteUser(Data.Models.User user)
        {
            WindowManager windowManager = WindowManager.Instance;
            var userService = windowManager.serviceProvider.GetService<IUserService>();
            bool success = true;
            switch ((WindowManager.USER_TYPES)user.UserTypeId)
            {
                case WindowManager.USER_TYPES.ADMIN:
                    if (!await userService.ChangeUserType(user, (int)WindowManager.USER_TYPES.STAFF)) success = false;
                    else LoadSchedulesTable();
                    break;
                case WindowManager.USER_TYPES.STAFF:
                    if (!await userService.ChangeUserType(user, (int)WindowManager.USER_TYPES.USER)) success = false;
                    else LoadSchedulesTable();
                    break;
                default:
                    success = false;
                    break;
            }
            if (!success) MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void DeleteUser(Data.Models.User user, Panel panel)
        {
            WindowManager windowManager = WindowManager.Instance;
            var userService = windowManager.serviceProvider.GetService<IUserService>();
            bool success = await userService.DeleteUser(user);
            if (success)
            {
                panel.Dispose();
                usersTable.PerformLayout();
            }
            else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
