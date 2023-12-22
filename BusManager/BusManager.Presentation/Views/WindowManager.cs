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
        private static WindowManager instance;

        private readonly LoginWindow loginWindow = new();
        private readonly RegisterWindow registerWindow = new();

        private WindowManager()
        {
            InitializeComponent();
            LoadScene(SCENES.LOGIN);
        }

        public static WindowManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WindowManager();
                }
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
