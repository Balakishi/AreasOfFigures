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
    public partial class Form_rhombus : Form
    {
        public Form_rhombus()
        {
            InitializeComponent();
        }
        double a, d1, d2, result_area, result_perimetr;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void textBox_d1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_d2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main frm = new Frm_main();
            this.Hide();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_perimetr_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text.Length > 0 && textBox_d1.Text.Length > 0 && textBox_d2.Text.Length > 0)
            {
                try
                {
                    a = Convert.ToDouble(textBox_a.Text);
                    d1 = Convert.ToDouble(textBox_d1.Text);
                    d2 = Convert.ToDouble(textBox_d2.Text);
                    result_area = (d1 * d2) / 2;
                    result_perimetr = 4 * a;
                    label_result.Text = Convert.ToString(result_area);
                    label_perimetr.Text = Convert.ToString(result_perimetr);
                 }
                catch
                {
                    MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_a.Text, @"[a-zA-Z]") ||
System.Text.RegularExpressions.Regex.IsMatch(textBox_d1.Text, @"[a-zA-Z]")|| System.Text.RegularExpressions.Regex.IsMatch(textBox_d1.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_a.Text == "" || textBox_d1.Text == ""|| textBox_d2.Text=="")
            {
                MessageBox.Show("Please enter the value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
    }
}

