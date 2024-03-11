namespace SchoolManegemantSystem
{
    partial class CourseManagement
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 0, 192);
            textBox1.Location = new Point(284, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Course Management";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(44, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 1;
            textBox2.Text = "Course ID";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(40, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 20);
            textBox3.TabIndex = 2;
            textBox3.Text = "Course Name";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(44, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 3;
            textBox4.Text = "Category";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(495, 178);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(209, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(175, 178);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(228, 27);
            textBox7.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Programming", "Developing", "Drawing", "Math", "Engineering" });
            comboBox2.Location = new Point(175, 245);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 28);
            comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(74, 412);
            button1.Name = "button1";
            button1.Size = new Size(133, 37);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(213, 412);
            button2.Name = "button2";
            button2.Size = new Size(135, 37);
            button2.TabIndex = 11;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 192);
            button3.ForeColor = Color.White;
            button3.Location = new Point(488, 423);
            button3.Name = "button3";
            button3.Size = new Size(121, 34);
            button3.TabIndex = 12;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 192);
            button4.ForeColor = Color.White;
            button4.Location = new Point(615, 423);
            button4.Name = "button4";
            button4.Size = new Size(113, 34);
            button4.TabIndex = 13;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 192);
            button5.ForeColor = Color.White;
            button5.Location = new Point(734, 423);
            button5.Name = "button5";
            button5.Size = new Size(116, 34);
            button5.TabIndex = 14;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 0, 192);
            button6.ForeColor = Color.White;
            button6.Location = new Point(716, 178);
            button6.Name = "button6";
            button6.Size = new Size(119, 27);
            button6.TabIndex = 15;
            button6.Text = "SEARCH";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(22, 13);
            button7.Name = "button7";
            button7.Size = new Size(185, 29);
            button7.TabIndex = 16;
            button7.Text = "Student Management";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(213, 13);
            button8.Name = "button8";
            button8.Size = new Size(166, 29);
            button8.TabIndex = 17;
            button8.Text = "Teacher Management";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(385, 12);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 18;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(371, 188);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(175, 211);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(228, 27);
            textBox6.TabIndex = 20;
            // 
            // CourseManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(891, 559);
            Controls.Add(textBox6);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CourseManagement";
            Text = "CourseManagement";
            Load += CourseManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox7;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridView1;
        private TextBox textBox6;
    }
}