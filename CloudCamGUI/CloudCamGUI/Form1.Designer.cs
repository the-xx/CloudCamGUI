namespace CloudCamGUI
{
    partial class Form1
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
            this.setSpeed = new System.Windows.Forms.TextBox();
            this.Rad = new System.Windows.Forms.TextBox();
            this.wind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newSpeed = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lamda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.energy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setSpeed
            // 
            this.setSpeed.Location = new System.Drawing.Point(151, 12);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(125, 20);
            this.setSpeed.TabIndex = 0;
            this.setSpeed.TextChanged += new System.EventHandler(this.setSpeed_TextChanged);
            // 
            // Rad
            // 
            this.Rad.Location = new System.Drawing.Point(151, 48);
            this.Rad.Name = "Rad";
            this.Rad.Size = new System.Drawing.Size(125, 20);
            this.Rad.TabIndex = 1;
            this.Rad.TextChanged += new System.EventHandler(this.Rad_TextChanged);
            // 
            // wind
            // 
            this.wind.Location = new System.Drawing.Point(151, 84);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(125, 20);
            this.wind.TabIndex = 2;
            this.wind.TextChanged += new System.EventHandler(this.wind_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newSpeed
            // 
            this.newSpeed.Location = new System.Drawing.Point(69, 210);
            this.newSpeed.Name = "newSpeed";
            this.newSpeed.Size = new System.Drawing.Size(125, 20);
            this.newSpeed.TabIndex = 4;
            this.newSpeed.TextChanged += new System.EventHandler(this.newSpeed_TextChanged);
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(151, 120);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(125, 20);
            this.grade.TabIndex = 10;
            this.grade.TextChanged += new System.EventHandler(this.grade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Setspeed";
            // 
            // lamda
            // 
            this.lamda.Location = new System.Drawing.Point(69, 164);
            this.lamda.Name = "lamda";
            this.lamda.Size = new System.Drawing.Size(125, 20);
            this.lamda.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lamda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Newspeed";
            // 
            // energy
            // 
            this.energy.Location = new System.Drawing.Point(235, 164);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(100, 20);
            this.energy.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.energy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lamda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.newSpeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.Rad);
            this.Controls.Add(this.setSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setSpeed;
        private System.Windows.Forms.TextBox Rad;
        private System.Windows.Forms.TextBox wind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newSpeed;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lamda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox energy;
    }
}

