namespace MRC
{
    partial class ControlRoom
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(343, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 36);
            label1.TabIndex = 0;
            label1.Text = "sensitivity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(574, 54);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 31);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(343, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 36);
            label2.TabIndex = 2;
            label2.Text = "up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(343, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 36);
            label3.TabIndex = 3;
            label3.Text = "down";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(343, 287);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 36);
            label4.TabIndex = 4;
            label4.Text = "right";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(343, 371);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 36);
            label5.TabIndex = 5;
            label5.Text = "left";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(343, 455);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 36);
            label6.TabIndex = 6;
            label6.Text = "right click";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(343, 540);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 36);
            label7.TabIndex = 7;
            label7.Text = "left click";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(574, 138);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 8;
            textBox1.KeyDown += textBox_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(574, 222);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 9;
            textBox2.KeyDown += textBox_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(574, 307);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(141, 31);
            textBox3.TabIndex = 10;
            textBox3.KeyDown += textBox_KeyDown;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(574, 391);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(141, 31);
            textBox4.TabIndex = 11;
            textBox4.KeyDown += textBox_KeyDown;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(574, 475);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(141, 31);
            textBox5.TabIndex = 12;
            textBox5.KeyDown += textBox_KeyDown;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(574, 560);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(141, 31);
            textBox6.TabIndex = 13;
            textBox6.KeyDown += textBox_KeyDown;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(574, 641);
            textBox7.Margin = new Padding(4, 5, 4, 5);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(141, 31);
            textBox7.TabIndex = 15;
            textBox7.KeyDown += textBox_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(343, 621);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 36);
            label8.TabIndex = 14;
            label8.Text = "drag/drop";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(574, 725);
            textBox8.Margin = new Padding(4, 5, 4, 5);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(141, 31);
            textBox8.TabIndex = 17;
            textBox8.KeyDown += textBox_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(343, 705);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 36);
            label9.TabIndex = 16;
            label9.Text = "on/off";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Location = new Point(989, 705);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(112, 54);
            button1.TabIndex = 18;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ControlRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1143, 791);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ForeColor = Color.Transparent;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ControlRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control Room";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private Button button1;
    }
}