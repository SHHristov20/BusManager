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
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return this.panel1;
        }
    }

}
