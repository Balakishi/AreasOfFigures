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
    public partial class Form_equalteral_trap : Form
    {
        public Form_equalteral_trap()
        {
            InitializeComponent();
        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {

        }
        double a, b, h, c, result_area, result_perimetr;

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main frm=new Frm_main();
            this.Hide();
            frm.ShowDialog();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text.Length > 0 && textBox_b.Text.Length > 0 && textBox_h.Text.Length > 0 &&
                textBox_cd.Text.Length > 0)
            {
                try
                {
                    a = Convert.ToDouble(textBox_a.Text);
                    b = Convert.ToDouble(textBox_b.Text);
                    h = Convert.ToDouble(textBox_h.Text);
                    c = Convert.ToDouble(textBox_cd.Text);
                    result_area = (a + b) * h / 2;
                    result_perimetr = a + b + 2 * c;
                    label_result.Text = Convert.ToString(result_area);
                    label_perimetr.Text = Convert.ToString(result_perimetr);
                }
                catch
                {
                    MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_a.Text, @"[a-zA-Z]") ||
System.Text.RegularExpressions.Regex.IsMatch(textBox_b.Text, @"[a-zA-Z]") || System.Text.RegularExpressions.Regex.
IsMatch(textBox_h.Text, @"[a-zA-Z]") ||System.Text.RegularExpressions.Regex.IsMatch(textBox_cd.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_h.Text == "" || textBox_cd.Text == "")
            {
                MessageBox.Show("Please enter the value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
