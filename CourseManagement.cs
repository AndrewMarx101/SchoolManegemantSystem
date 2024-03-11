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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManegemantSystem
{
    public partial class CourseManagement : Form
    {

        private SqlConnection connection;
        public CourseManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CourseManagement_Load(object sender, EventArgs e)
        {
            // Establish the database connection
            string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
            // Connection established successfully
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
            TeacherManagement teacherManagementForm = new TeacherManagement();

            // Show the TeachersManagement form
            teacherManagementForm.Show();

            // Hide the current Form1 form if desired
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student ID from a text box or any other input control
                string courseId = textBox7.Text;
                string courseName = textBox6.Text;
                string category = comboBox2.SelectedItem.ToString();


                // Construct the SQL query
                string query = "INSERT INTO CourseDetails (Course_ID, Course_Name, Category) VALUES (@CourseID, @CourseName, @Category)";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the student ID parameter to the query
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@CourseName", courseName);
                    command.Parameters.AddWithValue("@Category", category);


                    // Execute the query
                    command.ExecuteNonQuery();

                    // Show a success message
                    MessageBox.Show("Course details added successfully.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from textBox13
                string searchTerm = textBox5.Text;

                // Construct the SQL query with a parameter for the search term
                string query = "SELECT Course_ID, Course_Name, Category, Assigned_Teacher FROM CourseDetails WHERE Course_ID = @SearchTerm";

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
                    MessageBox.Show("Course details retrieved successfully.");
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
            comboBox2.SelectedIndex = -1;


            MessageBox.Show("Form cleared successfully.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student ID from the search term
                string courseId = textBox5.Text;

                // Construct the SQL query to delete the entry from the database table
                string query = "DELETE FROM CourseDetails WHERE Course_ID = @Course_Id";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the student ID parameter to the query
                    command.Parameters.AddWithValue("@Course_Id", courseId);

                    // Execute the delete query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check the number of rows affected by the delete query
                    if (rowsAffected > 0)
                    {
                        // Clear the form fields
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
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

        private void button3_Click(object sender, EventArgs e)
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
                            case "Course_Name":
                                // Construct the update query for Course_Name
                                string updateCourseNameQuery = "UPDATE CourseDetails SET Course_Name = @CourseName WHERE Course_ID = @CourseID";

                                using (SqlCommand command = new SqlCommand(updateCourseNameQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@CourseName", value);
                                    command.Parameters.AddWithValue("@CourseID", textBox5.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "Category":
                                // Construct the update query for Category
                                string updateCategoryQuery = "UPDATE CourseDetails SET Category = @Category WHERE Course_ID = @CourseID";

                                using (SqlCommand command = new SqlCommand(updateCategoryQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@Category", value);
                                    command.Parameters.AddWithValue("@CourseID", textBox5.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "Assigned_Teacher":
                                // Construct the update query for Category
                                string updateAssignedTeacherQuery = "UPDATE CourseDetails SET Assigned_Teacher = @AssignedTeacher WHERE Course_ID = @CourseID";

                                using (SqlCommand command = new SqlCommand(updateAssignedTeacherQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@AssignedTeacher", value);
                                    command.Parameters.AddWithValue("@CourseID", textBox5.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
