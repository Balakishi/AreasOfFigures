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
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_triangle.Text == "Right Triangle")
                {
                    label_select.Text = "";
                    Form_right_triangle frm = new Form_right_triangle();
                    frm.ShowDialog();
                }
                if (comboBox_triangle.Text == "Equalteral Triangle")
                {
                    label_select.Text = "";
                    Form_equalteral_triangle frm2 = new Form_equalteral_triangle();
                    frm2.ShowDialog();
                    
                }
            }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_rectangle.Text == "Square")
            {
                Form_square_rectangle frm3 = new Form_square_rectangle();
                frm3.ShowDialog();
            }

            if(comboBox_rectangle.Text=="Rectangle")
            {
                Form_Rectangle frm4= new Form_Rectangle();
                frm4.ShowDialog();
            }    
            if(comboBox_rectangle.Text=="Rhombus")
            {
                Form_rhombus frm5=new Form_rhombus();
                frm5.ShowDialog();
            }
            if(comboBox_rectangle.Text== "Equilateral trapezoid")
            {
                Form_equalteral_trap frm6=new Form_equalteral_trap();
                frm6.ShowDialog();
            }
        }

        private void comboBox_space_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_space.Text == "Cone")
            {
                Form_cone frm7 = new Form_cone();
                frm7.ShowDialog();
            }
            if(comboBox_space.Text=="Sphere")
            {
                Form_rectangular_sphere frm8 = new Form_rectangular_sphere();
                frm8.ShowDialog();
            }
            if(comboBox_space.Text=="Sylinder")
             {
                Form_sylinder frm9 = new Form_sylinder();
                frm9.ShowDialog();
            }
        }
    }
}
