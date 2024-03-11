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
    public partial class TeacherManagement : Form
    {
        private SqlConnection connection;
        public TeacherManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TeacherManagement_Load(object sender, EventArgs e)
        {
            // Establish the database connection
            string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
            // Connection established successfully
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Create an instance of the TeachersManagement form
            Form1 form1 = new Form1();

            // Show the TeachersManagement form
            form1.Show();

            // Hide the current Form1 form if desired
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the TeachersManagement form
            CourseManagement courseManagementForm = new CourseManagement();

            // Show the TeachersManagement form
            courseManagementForm.Show();

            // Hide the current Form1 form if desired
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student ID from a text box or any other input control
                string teacherId = textBox8.Text;
                string fullname = textBox9.Text;
                string gender = radioButton1.Checked ? "Male" : "Female";
                string course = textBox12.Text;
                string department = comboBox2.SelectedItem.ToString();
                string contactnumber = textBox10.Text;

                // Construct the SQL query
                string query = "INSERT INTO TeacherDetails (Teacher_ID, Gender, Full_Name, Course, Department, Contact_Number) VALUES (@TeacherID, @Gender, @FullName, @Course, @Department, @ContactNumber)";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the student ID parameter to the query
                    command.Parameters.AddWithValue("@TeacherId", teacherId);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@FullName", fullname);
                    command.Parameters.AddWithValue("@Course", course);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@ContactNumber", contactnumber);


                    // Execute the query
                    command.ExecuteNonQuery();

                    // Show a success message
                    MessageBox.Show("Teacher details added successfully.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from textBox13
                string searchTerm = textBox11.Text;

                // Construct the SQL query with a parameter for the search term
                string query = "SELECT Teacher_ID, Gender, full_name, course, department, contact_number FROM TeacherDetails WHERE Teacher_ID = @SearchTerm";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the search term parameter to the query
                    command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                    // Create a DataTable to store the query results
                    DataTable dataTable = new DataTable();

                    // Create a SqlDataAdapter to fill the DataTable with the query results
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataTable with the query results
                        dataAdapter.Fill(dataTable);
                    }

                    // Clear the existing DataGridView columns and rows
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();

                    // Add a column for the property names
                    dataGridView1.Columns.Add("Property", "Property");

                    // Add a column for the property values
                    dataGridView1.Columns.Add("Value", "Value");

                    // Iterate over the DataRow to populate the DataGridView
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            // Add a new row for each property and value
                            dataGridView1.Rows.Add(column.ColumnName, row[column.ColumnName]);
                        }
                    }

                    // Auto-size the columns to fit the content
                    dataGridView1.AutoResizeColumns();

                    // Show a success message
                    MessageBox.Show("Student details retrieved successfully.");
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
            textBox8.Clear();
            textBox9.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox2.SelectedIndex = -1;


            MessageBox.Show("Form cleared successfully.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student ID from the search term
                string teacherId = textBox11.Text;

                // Construct the SQL query to delete the entry from the database table
                string query = "DELETE FROM TeacherDetails WHERE Teacher_ID = @TeacherId";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the student ID parameter to the query
                    command.Parameters.AddWithValue("@TeacherId", teacherId);

                    // Execute the delete query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check the number of rows affected by the delete query
                    if (rowsAffected > 0)
                    {
                        // Clear the form fields
                        textBox8.Clear();
                        textBox9.Clear();
                        textBox12.Clear();
                        textBox11.Clear();
                        textBox10.Clear();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        comboBox2.SelectedIndex = -1;

                        // Show a success message
                        MessageBox.Show("Entry deleted successfully.");
                    }
                    else
                    {
                        // No matching record found
                        MessageBox.Show("No matching record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish the database connection
                string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Iterate over the rows in the DataGridView
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        // Extract the property and value information from the DataGridView
                        string property = dataGridView1.Rows[i].Cells["Property"].Value?.ToString();
                        string value = dataGridView1.Rows[i].Cells["Value"].Value?.ToString();

                        // Perform the update based on the property
                        switch (property)
                        {
                            case "full_name":
                                // Construct the update query for Full_Name
                                string updateFullNameQuery = "UPDATE TeacherDetails SET Full_Name = @FullName WHERE Teacher_ID = @TeacherID";

                                using (SqlCommand command = new SqlCommand(updateFullNameQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@FullName", value);
                                    command.Parameters.AddWithValue("@TeacherID", textBox11.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "contact_number":
                                // Construct the update query for Full_Name
                                string updateContactNumberQuery = "UPDATE TeacherDetails SET Contact_Number = @ContactNumber WHERE Teacher_ID = @TeacherID";

                                using (SqlCommand command = new SqlCommand(updateContactNumberQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ContactNumber", value);
                                    command.Parameters.AddWithValue("@TeacherID", textBox11.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "course":
                                // Construct the update query for Course
                                string updateCourseQuery = "UPDATE TeacherDetails SET Course = @Course WHERE Teacher_ID = @TeacherID";

                                using (SqlCommand command = new SqlCommand(updateCourseQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@Course", value);
                                    command.Parameters.AddWithValue("@TeacherID", textBox11.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            default:
                                // Ignore unrecognized properties
                                break;
                        }
                    }

                    // Show a success message
                    MessageBox.Show("Data updated successfully.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
