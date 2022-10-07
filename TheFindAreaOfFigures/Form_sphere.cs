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
    public partial class Form_rectangular_sphere : Form
    {
        public Form_rectangular_sphere()
        {
            InitializeComponent();
        }
        double r, result_area, result_volume;

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_main frm = new Frm_main();
            this.Hide();
            frm.ShowDialog();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (textBox_r.Text.Length>0)
            {
                try
                {
                    r = Convert.ToDouble(textBox_r.Text);

                    result_area = 4 * Math.PI * Math.Pow(r, 2);
                    result_volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
                    label_result.Text = Convert.ToString(result_area);
                    label_volume.Text = Convert.ToString(result_volume);
                }
                catch
                {
                    MessageBox.Show("Please enter numbers only!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBox_r.Text =="")
            {
                MessageBox.Show("Please enter the value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox_r.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
