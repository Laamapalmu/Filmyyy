using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Filmyyy
{
    public partial class Ajastin : Form
    {
        private int remainingTime;
        public Ajastin()
        {
            InitializeComponent();
        }

        int timeleft = 60;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                UpdateLabel();
            }
            else
            {
                timer.Stop();
                timerlabel.Text = "Time is up!";
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timeleft = ((int)numericUpDown1.Value * 60) + ((int)numericUpDown2.Value * 60) + (int)numericUpDown3.Value * 60;
            timer.Start();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = ((int)numericUpDown1.Value * 60) + ((int)numericUpDown2.Value * 60) + (int)numericUpDown3.Value * 60;
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            TimeSpan timeRemaining = TimeSpan.FromSeconds(timeleft);
            timerlabel.Text = timeRemaining.ToString(@"hh\:mm\:ss");
        }
    }
}
