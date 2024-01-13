using BusManager.Core.Implementations;
using BusManager.Core.Interfaces;
using BusManager.Data.Data.Contexts;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
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
        public User? LoggedUser { get; set; } = null!;

        private readonly LoginWindow loginWindow = new();
        private readonly RegisterWindow registerWindow = new();
        private readonly StationManager stationManager = new();
        private readonly ScheduleManager scheduleManager = new();
        private readonly BookTicket bookTicket = new();

        public ServiceProvider serviceProvider = new ServiceCollection()
            .AddDbContext<BusManagerDbContext>()
            .AddSingleton<UserRepository>()
            .AddSingleton<UserTypeRepository>()
            .AddSingleton<CityRepository>()
            .AddSingleton<StationRepository>()
            .AddSingleton<ScheduleRepository>()
            .AddSingleton<TicketRepository>()
            .AddSingleton<IUserService, UserService>()
            .AddSingleton<IStationService, StationService>()
            .AddSingleton<IScheduleService, ScheduleService>()
            .AddSingleton<ITicketService, TicketService>()
            .BuildServiceProvider();

        private WindowManager()
        {
            
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            REGISTER,
            STATION_MANAGER,
            SCHEDULE_MANAGER,
            BOOK_TICKET
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
                case SCENES.STATION_MANAGER:
                    this.Controls.Add(stationManager.GetPanel());
                    break;
                case SCENES.SCHEDULE_MANAGER:
                    this.Controls.Add(scheduleManager.GetPanel());
                    break;
                case SCENES.BOOK_TICKET:
                    this.Controls.Add(bookTicket.GetPanel());
                    break;
            }
        }
    }
}
