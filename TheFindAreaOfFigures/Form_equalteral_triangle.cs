using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheFindAreaOfFigures
{
    public partial class Form_equalteral_triangle : Form
    {
        public Form_equalteral_triangle()
        {
            InitializeComponent();
        }
        double a, result_area, result_perimetr;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void label_perimetr_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main main = new Frm_main();
            this.Hide();
            main.ShowDialog();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text.Length > 0)
            {
                try
                {
                    a = Convert.ToDouble(textBox_a.Text);
                    result_area = (Math.Sqrt(3) * Math.Pow(a, 2) / 4);
                    result_perimetr = 3 * a;
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
            else if (textBox_a.Text=="")
            {
                MessageBox.Show("Please enter the value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
