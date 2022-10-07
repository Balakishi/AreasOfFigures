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
    public partial class Form_sylinder : Form
    {
        public Form_sylinder()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        double r, h, result_area, result_volume;

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void textBox_r_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_h_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_volume_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main frm = new Frm_main();
            this.Hide();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_r.Text.Length>0 && textBox_h.Text.Length>0 && textBox_r.Text !="" && textBox_r.Text!="")
            {
                try
                {
                    r = Convert.ToDouble(textBox_r.Text);
                    h = Convert.ToDouble(textBox_h.Text);
                    result_area = 2 * Math.PI * Math.Pow(r, 2) + 2 * Math.PI * r * h;
                    result_volume = Math.PI * Math.Pow(r, 2) * h;
                    label_result.Text = Convert.ToString(result_area);
                    label_volume.Text = Convert.ToString(result_volume);
                }
                catch
                {
                 MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_r.Text, @"[a-zA-Z]")||
                System.Text.RegularExpressions.Regex.IsMatch(textBox_h.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_h.Text=="" & textBox_r.Text=="")
            {
                MessageBox.Show("Please enter the value!","ERROR!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
