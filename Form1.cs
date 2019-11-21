using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryAlarm
{
    public partial class primaryLayout : Form
    {
        public primaryLayout()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void Level()
        {
            while (true)
            {
                PowerStatus power = SystemInformation.PowerStatus;
                label3.Text = power.BatteryChargeStatus.ToString();
            }
        }

    }
}
