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
    public partial class Form_cone : Form
    {
        public Form_cone()
        {
            InitializeComponent();
        }
        double h, r, s, result_area, result_volume;

        private void textBox_h_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_s_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main frm=new Frm_main();
            this.Hide();
            frm.ShowDialog();
        }

        private void Form_cone_Load(object sender, EventArgs e)
        {

        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_s.Text.Length>0 && textBox_r.Text.Length>0 && textBox_h.Text.Length>0)
            {
                try
                {
                    s = Convert.ToDouble(textBox_s.Text);
                    r = Convert.ToDouble(textBox_r.Text);
                    h = Convert.ToDouble(textBox_h.Text);
                    result_area = Math.PI * Math.Pow(r, 2) + Math.PI * r * s;
                    result_volume = (Math.PI * Math.Pow(r, 2) * h) / 3;
                    label_result.Text = Convert.ToString(result_area);
                    label_volume.Text = Convert.ToString(result_volume);
                }
                catch
                {
                    MessageBox.Show("please enter the number value!", "ERROR!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_s.Text, @"[a-zA-Z]") ||
System.Text.RegularExpressions.Regex.IsMatch(textBox_r.Text, @"[a-zA-Z]") || 
System.Text.RegularExpressions.Regex.IsMatch(textBox_h.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textBox_s.Text == "" || textBox_r.Text == "" || textBox_h.Text == "")
                {
                    MessageBox.Show("You don't enter the value,please enter the value!", "ERROR!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                
                }
                 
            
        }
    }
}
