using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeUni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Practice1_Click(object sender, EventArgs e)
        {

            FirstTask Calculate = new FirstTask();
            double xn, xk, h, a;
            try
            {
                xn = Convert.ToDouble(this.XnText.Text);
                xk = Convert.ToDouble(this.XkText.Text);
                h = Convert.ToDouble(this.hText.Text);
                a = Convert.ToDouble(this.aText.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly entered data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            Calculate.Calculate(xn, xk, h, a);
            for (int i = 0; i < Calculate.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(Calculate.xy[i, 0], 2).ToString(),
                    Math.Round(Calculate.xy[i,1],3).ToString());
                chart1.Series[0].Points.AddXY(Calculate.xy[i, 0], Calculate.xy[i, 1]);
            }
        }

        private void onearrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new OneArr();
            Form.Show();
            this.Hide();
        }

        private void twoarrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new TwoArr();
            Form.Show();
            this.Hide();
        }
    }
}
