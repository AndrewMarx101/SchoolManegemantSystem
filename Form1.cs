using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace SchoolManegemantSystem
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Establish the database connection
            string connectionString = "Data Source=LAPTOP-F83ENH80;Initial Catalog=SchoolManagmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
            // Connection established successfully
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox8.Clear();
            textBox9.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;


            MessageBox.Show("Form cleared successfully.");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student ID from a text box or any other input control
                string studentId = textBox8.Text;
                string fullname = textBox9.Text;
                string gender = radioButton1.Checked ? "Male" : "Female";
                string courseEnrolled = comboBox1.SelectedItem.ToString();
                string contactnumber = textBox11.Text;
                string adress = textBox12.Text;

                // Construct the SQL query
                string query = "INSERT INTO StudentDetails (Student_ID, Gender, full_name, course_enrolled, contact_number, adress) VALUES (@StudentID, @Gender, @FullName, @CourseEnrolled, @ContactNumber, @Adress)";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the student ID parameter to the query
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@FullName", fullname);
                    command.Parameters.AddWithValue("@CourseEnrolled", courseEnrolled);
                    command.Parameters.AddWithValue("@ContactNumber", contactnumber);
                    command.Parameters.AddWithValue("@Adress", adress);

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Show a success message
                    MessageBox.Show("Student details added successfully.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from textBox13
                string searchTerm = textBox13.Text;

                // Construct the SQL query with a parameter for the search term
                string query = "SELECT Student_ID, Full_Name, Gender, Course_Enrolled, Contact_Number, Adress, Grade_Level FROM StudentDetails WHERE Student_ID = @SearchTerm";

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
                            case "Full_Name":
                                // Construct the update query for Full_Name
                                string updateFullNameQuery = "UPDATE StudentDetails SET Full_Name = @FullName WHERE Student_ID = @StudentID";

                                using (SqlCommand command = new SqlCommand(updateFullNameQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@FullName", value);
                                    command.Parameters.AddWithValue("@StudentID", textBox13.Text);

                                    // Execute the update query for Course_Name
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "Contact_Number":
                                // Construct the update query for Full_Name
                                string updateContactNumberQuery = "UPDATE StudentDetails SET Contact_Number = @ContactNumber WHERE Student_ID = @StudentID";

                                using (SqlCommand command = new SqlCommand(updateContactNumberQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ContactNumber", value);
                                    command.Parameters.AddWithValue("@StudentID", textBox13.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "Adress":
                                // Construct the update query for Course
                                string updateAdressQuery = "UPDATE StudentDetails SET Adress = @Adress WHERE Student_ID = @StudentID";

                                using (SqlCommand command = new SqlCommand(updateAdressQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@Adress", value);
                                    command.Parameters.AddWithValue("@StudentID", textBox13.Text);
                                    command.ExecuteNonQuery();
                                }
                                break;

                            case "Grade_Level":
                                // Construct the update query for Course
                                string updateGradeLevelQuery = "UPDATE StudentDetails SET Grade_Level = @GradeLevel WHERE Student_ID = @StudentID";

                                using (SqlCommand command = new SqlCommand(updateGradeLevelQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@GradeLevel", value);
                                    command.Parameters.AddWithValue("@StudentID", textBox13.Text);
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



        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student ID from the search term
                string studentId = textBox13.Text;

                // Construct the SQL query to delete the entry from the database table
                string query = "DELETE FROM StudentDetails WHERE Student_ID = @StudentId";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the student ID parameter to the query
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    // Execute the delete query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check the number of rows affected by the delete query
                    if (rowsAffected > 0)
                    {
                        // Clear the form fields
                        textBox8.Clear();
                        textBox9.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        comboBox1.SelectedIndex = -1;

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



        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void button7_Click(object sender, EventArgs e)
        {
            // Create an instance of the TeachersManagement form
            TeacherManagement teacherManagementForm = new TeacherManagement();

            // Show the TeachersManagement form
            teacherManagementForm.Show();

            // Hide the current Form1 form if desired
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the CourseManagement form
            CourseManagement CourseManagementForm = new CourseManagement();

            // Show the TeachersManagement form
            CourseManagementForm.Show();

            // Hide the current Form1 form if desired
            this.Hide();
        }
    }
}