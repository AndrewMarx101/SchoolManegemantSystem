namespace SchoolManegemantSystem
{
    partial class TeacherManagement
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
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox11 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            textBox12 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 0, 192);
            textBox1.Location = new Point(321, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Teacher Management";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(38, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 1;
            textBox2.Text = "Teacher ID";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(38, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 2;
            textBox3.Text = "Full Name";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(38, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 3;
            textBox4.Text = "Gender";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(38, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 20);
            textBox5.TabIndex = 4;
            textBox5.Text = "Course";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(38, 314);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 20);
            textBox6.TabIndex = 5;
            textBox6.Text = "Department";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(38, 347);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 20);
            textBox7.TabIndex = 6;
            textBox7.Text = "Contact Number";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(189, 182);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(202, 27);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(189, 215);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(202, 27);
            textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(189, 346);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(202, 27);
            textBox10.TabIndex = 9;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(189, 248);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(258, 248);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Computer Science", "Business Administration", "Psychology", "Engineering", "Literature and Languages" });
            comboBox2.Location = new Point(189, 312);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(202, 28);
            comboBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(72, 423);
            button1.Name = "button1";
            button1.Size = new Size(119, 31);
            button1.TabIndex = 14;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(215, 424);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 15;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(518, 182);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(216, 27);
            textBox11.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 192);
            button3.ForeColor = Color.White;
            button3.Location = new Point(740, 180);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 192);
            button4.ForeColor = Color.White;
            button4.Location = new Point(518, 423);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 19;
            button4.Text = "EDIT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 192);
            button5.ForeColor = Color.White;
            button5.Location = new Point(618, 423);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 20;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 0, 192);
            button6.ForeColor = Color.White;
            button6.Location = new Point(718, 424);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 21;
            button6.Text = "EXIT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(35, 11);
            button7.Name = "button7";
            button7.Size = new Size(160, 29);
            button7.TabIndex = 22;
            button7.Text = "Student Management";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(201, 12);
            button8.Name = "button8";
            button8.Size = new Size(166, 29);
            button8.TabIndex = 23;
            button8.Text = "Course Management";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(373, 12);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 24;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "dataGridView1";
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(458, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(376, 202);
            dataGridView1.TabIndex = 25;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(189, 278);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(202, 27);
            textBox12.TabIndex = 26;
            // 
            // TeacherManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 548);
            Controls.Add(textBox12);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox11);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TeacherManagement";
            Text = "Teacher Management";
            Load += TeacherManagement_Load;
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
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox11;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridView1;
        private TextBox textBox12;
    }
}