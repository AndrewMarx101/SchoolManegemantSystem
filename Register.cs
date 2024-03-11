using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManegemantSystem
{

    public partial class Register : Form
    {
        private SqlConnection connection;
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Establish the database connection
            string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
            // Connection established successfully

            textBox6.UseSystemPasswordChar = true;
            textBox7.UseSystemPasswordChar = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = !checkBox1.Checked;
            textBox7.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the Login form if not already created
            Login loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault() ?? new Login();

            // Show the Login form
            loginForm.Show();

            // Close the Register form
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string password = textBox6.Text;
            string confPassword = textBox7.Text;

            // Perform validation checks
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                // Establish the database connection
                string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construct the SQL query
                    string query = "INSERT INTO UserDetails (Username, Password) VALUES (@username, @password)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the username and password parameters to the query
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show("Registration successful. User details added to the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }
    }
}
