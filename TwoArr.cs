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
    public partial class TwoArr : Form
    {
        public TwoArr()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0, m = 0;
                n = Convert.ToInt32(Colom.Text);
                m = Convert.ToInt32(Row.Text);
                MatrixArr matrixArr = new MatrixArr(n, m);
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                DataGridViewTextBoxColumn datag = new DataGridViewTextBoxColumn();
                for (int i = 0; i < m; i++)
                {
                    datag.Width = 40;
                    dataGridView1.Columns.Add(datag);
                }
                dataGridView1.RowCount = matrixArr.X_length;
                dataGridView1.ColumnCount = matrixArr.Y_length;
                for (int i = 0; i < matrixArr.X_length; i++)
                    for (int j = 0; j < matrixArr.Y_length; j++)
                        dataGridView1.Rows[i].Cells[j].Value = matrixArr[i, j].ToString();
                var result = matrixArr.Index_number();

                RESLab.Text = result;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
