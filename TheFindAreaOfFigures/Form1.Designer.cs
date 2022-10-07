namespace TheFindAreaOfFigures
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_triangle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_rectangle = new System.Windows.Forms.ComboBox();
            this.comboBox_space = new System.Windows.Forms.ComboBox();
            this.label_select = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Baskerville", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to my app which that find area of figures!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Priva Three", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select figure which you want to find area of it:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_triangle
            // 
            this.comboBox_triangle.FormattingEnabled = true;
            this.comboBox_triangle.Items.AddRange(new object[] {
            "Right Triangle",
            "Equalteral Triangle"});
            this.comboBox_triangle.Location = new System.Drawing.Point(91, 235);
            this.comboBox_triangle.Name = "comboBox_triangle";
            this.comboBox_triangle.Size = new System.Drawing.Size(153, 21);
            this.comboBox_triangle.TabIndex = 2;
            this.comboBox_triangle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Museo 900", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(126, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Triangle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Museo 900", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(336, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rectangle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Museo 900", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(574, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Space figures:";
            // 
            // comboBox_rectangle
            // 
            this.comboBox_rectangle.FormattingEnabled = true;
            this.comboBox_rectangle.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Rhombus",
            "Equilateral trapezoid"});
            this.comboBox_rectangle.Location = new System.Drawing.Point(300, 235);
            this.comboBox_rectangle.Name = "comboBox_rectangle";
            this.comboBox_rectangle.Size = new System.Drawing.Size(154, 21);
            this.comboBox_rectangle.TabIndex = 6;
            this.comboBox_rectangle.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox_space
            // 
            this.comboBox_space.FormattingEnabled = true;
            this.comboBox_space.Items.AddRange(new object[] {
            "Cone",
            "Sylinder",
            "Sphere"});
            this.comboBox_space.Location = new System.Drawing.Point(554, 235);
            this.comboBox_space.Name = "comboBox_space";
            this.comboBox_space.Size = new System.Drawing.Size(154, 21);
            this.comboBox_space.TabIndex = 7;
            this.comboBox_space.SelectedIndexChanged += new System.EventHandler(this.comboBox_space_SelectedIndexChanged);
            // 
            // label_select
            // 
            this.label_select.AutoSize = true;
            this.label_select.BackColor = System.Drawing.Color.White;
            this.label_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_select.Location = new System.Drawing.Point(88, 238);
            this.label_select.Name = "label_select";
            this.label_select.Size = new System.Drawing.Size(110, 13);
            this.label_select.TabIndex = 8;
            this.label_select.Text = "Please select triangle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(297, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Please select rectangle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(551, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Please select space figure:";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.comboBox_space);
            this.Controls.Add(this.comboBox_rectangle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_triangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finder Area of figures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_triangle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_rectangle;
        private System.Windows.Forms.ComboBox comboBox_space;
        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

