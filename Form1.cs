using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryAlarm
{
    public partial class primaryLayout : Form
    {
        public primaryLayout()
        {
            InitializeComponent();
            //while (true)
            //{
                PowerStatus power = SystemInformation.PowerStatus;
                label3.Text = power.BatteryChargeStatus.ToString();
                //Thread.Sleep(2000);
            //}
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }      
    }
}
