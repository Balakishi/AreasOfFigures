namespace TheFindAreaOfFigures
{
    partial class Form_sylinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_sylinder));
            this.label_volume = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_result = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.Location = new System.Drawing.Point(700, 400);
            this.label_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_volume.Name = "label_volume";
            this.label_volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_volume.Size = new System.Drawing.Size(0, 28);
            this.label_volume.TabIndex = 18;
            this.label_volume.Click += new System.EventHandler(this.label_volume_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nivea", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Volume:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nivea", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Area:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("Nautilus Pompilius", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_result.Location = new System.Drawing.Point(463, 280);
            this.button_result.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(497, 47);
            this.button_result.TabIndex = 15;
            this.button_result.Text = "The area and volume of this figure(please click):";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(700, 352);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 28);
            this.label_result.TabIndex = 14;
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // textBox_r
            // 
            this.textBox_r.Font = new System.Drawing.Font("Nivea", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_r.Location = new System.Drawing.Point(760, 197);
            this.textBox_r.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_r.Multiline = true;
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(226, 30);
            this.textBox_r.TabIndex = 13;
            this.textBox_r.TextChanged += new System.EventHandler(this.textBox_r_TextChanged);
            // 
            // textBox_h
            // 
            this.textBox_h.Font = new System.Drawing.Font("Nivea", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_h.Location = new System.Drawing.Point(760, 117);
            this.textBox_h.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_h.Multiline = true;
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(226, 30);
            this.textBox_h.TabIndex = 12;
            this.textBox_h.TextChanged += new System.EventHandler(this.textBox_h_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(429, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please enter value of r:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter value of h:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(406, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 71);
            this.btn_back.TabIndex = 21;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_sylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheFindAreaOfFigures.Properties.Resources._425px_Circular_cylinder_rh_svg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 471);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_sylinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_sylinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}