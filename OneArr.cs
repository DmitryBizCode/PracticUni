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
    public partial class OneArr : Form
    {
        public OneArr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            try
            {
                if(!string.IsNullOrWhiteSpace(sur1.Text) && !string.IsNullOrWhiteSpace(sur1.Text) && !string.IsNullOrWhiteSpace(sur1.Text)
                    && !string.IsNullOrWhiteSpace(sur1.Text) && !string.IsNullOrWhiteSpace(sur1.Text))
                {
                    string[] surname = { sur1.Text, sur2.Text, sur3.Text, sur4.Text, sur5.Text};
                    var arrone = new ArrayOne(surname);
                    arrone.Reverse();
                    for (int i = 0; i < arrone.Length; ++i)
                        dataGridView1.Rows.Add(arrone[i]);
                }
                else
                {
                    var arrone = new ArrayOne(5);
                    arrone.Reverse();
                    for (int i = 0; i < arrone.Length; ++i)
                        dataGridView1.Rows.Add(arrone[i]);
                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
