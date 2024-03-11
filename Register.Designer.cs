namespace SchoolManegemantSystem
{
    partial class Register
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
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(130, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Get Started";
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "new_username";
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(67, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 1;
            textBox2.Text = "Username";
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "new_password";
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(67, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 2;
            textBox3.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.AccessibleName = "conf_new_password";
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(67, 299);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 3;
            textBox4.Text = "Confirm Password";
            // 
            // textBox5
            // 
            textBox5.AccessibleName = "username";
            textBox5.Location = new Point(67, 150);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 27);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.AccessibleName = "password";
            textBox6.Location = new Point(67, 241);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 27);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.AccessibleName = "conf_password";
            textBox7.Location = new Point(67, 332);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(264, 27);
            textBox7.TabIndex = 6;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(197, 365);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(79, 430);
            button1.Name = "button1";
            button1.Size = new Size(223, 37);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(79, 473);
            button2.Name = "button2";
            button2.Size = new Size(223, 38);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 0, 192);
            button3.Location = new Point(134, 591);
            button3.Name = "button3";
            button3.Size = new Size(122, 29);
            button3.TabIndex = 10;
            button3.Text = "Back to LOGIN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(109, 558);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(176, 20);
            textBox8.TabIndex = 11;
            textBox8.Text = "Already Have an Account";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(387, 671);
            Controls.Add(textBox8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load_1;
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
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox8;
    }
}