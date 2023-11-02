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
    public partial class SOLID : Form
    {
        public SOLID()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new Array_change();
            var file = new Infile();
            var show = new Show_arr_solid();
            var fileout = new Outfile();
            string namefile = "1.txt";
            try
            {

                if (string.IsNullOrWhiteSpace(File_name.Text))
                {
                    a.Create_array();//create array random
                    //
                    Arrxa.Text = show.Show_arr(a.arr1);
                    Arrya.Text = show.Show_arr(a.arr2);
                    //
                    a.Update_array();//change array
                    //
                    Arrxb.Text = show.Show_arr(a.arr1);
                    Arryb.Text = show.Show_arr(a.arr2);
                    //
                    if (InfileCheck.Checked)                    
                        file.Writeinit(namefile,a);
                    
                }
                else
                {
                    fileout.Readfromit(File_name.Text, a); //create array from file
                    //
                    Arrxa.Text = show.Show_arr(a.arr1);
                    Arrya.Text = show.Show_arr(a.arr2);
                    //
                    a.Update_array();//change array
                    //
                    Arrxb.Text = show.Show_arr(a.arr1);
                    Arryb.Text = show.Show_arr(a.arr2);
                    //
                    if (InfileCheck.Checked)
                        file.Writeinit(namefile, a);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
