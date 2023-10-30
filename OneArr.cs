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
                    sur1.Text = arrone[0];
                    sur2.Text = arrone[1];
                    sur3.Text = arrone[2];
                    sur4.Text = arrone[3];
                    sur5.Text = arrone[4];

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
