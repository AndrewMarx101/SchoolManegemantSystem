namespace SchoolManegemantSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 0, 192);
            textBox1.Location = new Point(349, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Student Management";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "student_idbar";
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(36, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 20);
            textBox2.TabIndex = 1;
            textBox2.Text = "Student ID";
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "full_namebar";
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(36, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(81, 20);
            textBox3.TabIndex = 2;
            textBox3.Text = "Full Name";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(36, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 20);
            textBox4.TabIndex = 3;
            textBox4.Text = "Gender";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(36, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 20);
            textBox5.TabIndex = 4;
            textBox5.Text = "Course Enrolled";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(36, 302);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 20);
            textBox6.TabIndex = 5;
            textBox6.Text = "Contact Number";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(36, 335);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(60, 20);
            textBox7.TabIndex = 6;
            textBox7.Text = "Adress";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(192, 237);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(259, 236);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.AccessibleName = "add_student";
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(110, 513);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 9;
            button1.Text = "ADD STUDENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "clear";
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(256, 513);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AccessibleName = "search";
            button3.BackColor = Color.FromArgb(0, 0, 192);
            button3.ForeColor = Color.White;
            button3.Location = new Point(784, 168);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox8
            // 
            textBox8.AccessibleName = "student_ID";
            textBox8.BackColor = Color.White;
            textBox8.Location = new Point(191, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(211, 27);
            textBox8.TabIndex = 12;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.AccessibleName = "full_name";
            textBox9.Location = new Point(191, 203);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(211, 27);
            textBox9.TabIndex = 13;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox11
            // 
            textBox11.AccessibleName = "contact_number";
            textBox11.Location = new Point(191, 303);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(211, 27);
            textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            textBox12.AccessibleName = "adress";
            textBox12.Location = new Point(191, 335);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(211, 27);
            textBox12.TabIndex = 16;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(535, 169);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(243, 27);
            textBox13.TabIndex = 17;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // button4
            // 
            button4.AccessibleName = "update";
            button4.BackColor = Color.FromArgb(0, 0, 192);
            button4.ForeColor = Color.White;
            button4.Location = new Point(547, 513);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AccessibleName = "delete";
            button5.BackColor = Color.FromArgb(0, 0, 192);
            button5.ForeColor = Color.White;
            button5.Location = new Point(647, 513);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 19;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AccessibleName = "exit";
            button6.BackColor = Color.FromArgb(0, 0, 192);
            button6.ForeColor = Color.White;
            button6.Location = new Point(747, 513);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 20;
            button6.Text = "EXIT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "course_enrolled";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Software Development", "Digital Designer", "Gaming Developer", "Digital Draughting", "App Developer" });
            comboBox1.Location = new Point(192, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 28);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(12, 12);
            button7.Name = "button7";
            button7.Size = new Size(227, 29);
            button7.TabIndex = 23;
            button7.Text = "Teacher Management";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(245, 12);
            button8.Name = "button8";
            button8.Size = new Size(233, 29);
            button8.TabIndex = 24;
            button8.Text = "Course Management";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(484, 12);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 25;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "dataGridView1";
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(484, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(394, 252);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AccessibleName = "course_enrolled";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 618);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Student Management";
            Load += Form1_Load;
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
        private TextBox textBox6;
        private TextBox textBox7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridView1;
    }
}