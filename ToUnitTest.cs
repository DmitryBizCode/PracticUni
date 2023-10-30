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
    public partial class ToUnitTest : Form
    {
        public ToUnitTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var pr3 = new Pract3(double.Parse(linea_task1.Text), double.Parse(lineb_task1.Text), double.Parse(linec_task1.Text));
                double res = pr3.Calculate_First();
                result.Text = res.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var pr3 = new Pract3(int.Parse(linea_task2.Text), int.Parse(lineb_task2.Text));
                double res = pr3.Calculate_Second();                
                resulttask2.Text = res.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
