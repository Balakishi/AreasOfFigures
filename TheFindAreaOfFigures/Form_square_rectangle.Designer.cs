namespace TheFindAreaOfFigures
{
    partial class Form_square_rectangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_square_rectangle));
            this.label_perimetr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_result = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_perimetr
            // 
            this.label_perimetr.AutoSize = true;
            this.label_perimetr.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_perimetr.Location = new System.Drawing.Point(550, 310);
            this.label_perimetr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_perimetr.Name = "label_perimetr";
            this.label_perimetr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_perimetr.Size = new System.Drawing.Size(0, 28);
            this.label_perimetr.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nivea", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 24;
            this.label4.Text = "Perimetr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nivea", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Area:";
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("Nautilus Pompilius", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_result.Location = new System.Drawing.Point(313, 183);
            this.button_result.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(497, 47);
            this.button_result.TabIndex = 22;
            this.button_result.Text = "The area and perimetr of this rectangle(please click):";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(550, 262);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 28);
            this.label_result.TabIndex = 21;
            // 
            // textBox_a
            // 
            this.textBox_a.Font = new System.Drawing.Font("Nivea", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_a.Location = new System.Drawing.Point(607, 101);
            this.textBox_a.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_a.Multiline = true;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(226, 30);
            this.textBox_a.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Nivea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Please enter value of a:";
            // 
            // btn_back
            // 
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(83, 334);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 71);
            this.btn_back.TabIndex = 26;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_square_rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TheFindAreaOfFigures.Properties.Resources.s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label_perimetr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label1);
            this.Name = "Form_square_rectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_square_rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_perimetr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}