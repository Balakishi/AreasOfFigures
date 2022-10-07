using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFindAreaOfFigures
{
    public partial class Form_square_rectangle : Form
    {
        public Form_square_rectangle()
        {
            InitializeComponent();
        }
        double a, result_area, result_perimetr;

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main frm = new Frm_main(); 
            this.Hide();
            frm.ShowDialog();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text.Length > 0)
            {
                try
                {

                    a = Convert.ToDouble(textBox_a.Text);
                    result_area = Math.Pow(a, 2);
                    result_perimetr = 4 * a;
                    label_result.Text = Convert.ToString(result_area);
                    label_perimetr.Text = Convert.ToString(result_perimetr);
                }
                catch
                {
                    MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_a.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox_a.Text == "")
            {
                MessageBox.Show("Please enter the value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
    }
}
