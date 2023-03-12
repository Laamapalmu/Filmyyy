using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmyyy
{
    public partial class DistancePage : Form
    {
        public DistancePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = (double)numericUpDown1.Value;
            double num2 = (double)numericUpDown2.Value;
            double num3 = (double)numericUpDown3.Value;

            if (checkBox1.Checked)
            {
                double div = num2 / num1;
                double result1 = Math.Pow(div, 2);
                double result2 = result1 * num3;
                labelTime.Text = result2 + " seconds";
            }
            else
            {
                double div = num1 / num2;
                double result1 = Math.Pow(div, 2);
                double result2 = result1 * num3;
                labelTime.Text = result2 + " seconds";
            }
        }
    }
}
