using BusManager.Core.Implementations;
using BusManager.Core.Interfaces;
using BusManager.Data.Data.Contexts;
using BusManager.Data.Data.Repositories;
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

namespace BusManager.Presentation.Views
{
    public partial class WindowManager : Form
    {
        private static WindowManager instance = null!;

        private readonly LoginWindow loginWindow = new();
        private readonly RegisterWindow registerWindow = new();

        public ServiceProvider serviceProvider = new ServiceCollection()
            .AddDbContext<BusManagerDbContext>()
            .AddSingleton<UserRepository>()
            .AddSingleton<UserTypeRepository>()
            .AddSingleton<IUserService, UserService>()
            .BuildServiceProvider();

        private WindowManager()
        {
            
            InitializeComponent();
            LoadScene(SCENES.LOGIN);
        }

        public static WindowManager Instance
        {
            get
            {
                instance ??= new WindowManager();
                return instance;
            }
        }

        public enum SCENES
        {
            LOGIN,
            REGISTER
        }

        public void LoadScene(SCENES scene)
        {
            this.Controls.Clear();
            switch (scene)
            {
                case SCENES.LOGIN:
                    this.Controls.Add(loginWindow.GetPanel());
                    break;
                case SCENES.REGISTER:
                    this.Controls.Add(registerWindow.GetPanel());
                    break;
            }
        }
    }
}
