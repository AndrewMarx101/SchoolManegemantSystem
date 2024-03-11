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
    public partial class Login : Form
    {
        private SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Establish the database connection
            string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
            // Connection established successfully

            textBox6.UseSystemPasswordChar = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the Register form if not already created
            Register registerForm = Application.OpenForms.OfType<Register>().FirstOrDefault() ?? new Register();

            // Show the Register form
            registerForm.Show();

            // Hide the Login form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string password = textBox6.Text;

            try
            {
                // Establish the database connection
                string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construct the SQL query to check the username and password
                    string query = "SELECT COUNT(*) FROM UserDetails WHERE Username = @username AND Password = @password";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the username and password parameters to the query
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the result
                        int count = (int)command.ExecuteScalar();

                        // Check if the count is greater than 0, indicating that the username and password are correct
                        if (count > 0)
                        {
                            // Show a success message
                            MessageBox.Show("Login successful.");

                            // Create an instance of Form1 and show it
                            Form1 form1 = new Form1();
                            form1.Show();

                            // Hide the Login form
                            this.Hide();
                        }
                        else
                        {
                            // Show an error message if the username and password are incorrect
                            MessageBox.Show("Invalid username or password.");
                        }
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
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
