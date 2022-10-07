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
    public partial class Form_right_triangle : Form
    {
        public Form_right_triangle()
        {
            InitializeComponent();
        }


        private void Form_right_triangle_Load(object sender, EventArgs e)
        {

        }



        private void textBox_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {

        }
        double result_area;
        double result_perimetr;
        double a, b,c;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_perimetr_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main main=new Frm_main();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_a.Text.Length > 0 && textBox_b.Text.Length >0)
                try
                {
                    {
                        a = Convert.ToDouble(textBox_a.Text);
                        b = Convert.ToDouble(textBox_b.Text);
                        c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                        result_area = (a * b) / 2;
                        result_perimetr = a + b + c;
                        label_result.Text = Convert.ToString(result_area);
                        label_perimetr.Text = Convert.ToString(result_perimetr);
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_a.Text, @"[a-zA-Z]") ||
    System.Text.RegularExpressions.Regex.IsMatch(textBox_b.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_a.Text == "" || textBox_b.Text == "")
            {
                MessageBox.Show("Please enter the value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void label_result_Click(object sender, EventArgs e)
        {
            

        }
    }
}
