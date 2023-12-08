using Product_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grading_Student
{
    public partial class ViewGrading : Form
    {
        private SqlConnection connection;

        public ViewGrading(string Role)
        {
            InitializeComponent();

            // Initialize database connection
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");

            // Display the user role in a label
            lab_user.Text = "User: " + Role;
        }

        // Event handler for the search button click
        private void btn_search_Click(object sender, EventArgs e)
        {
            // Get the search value from the text box
            string search = txt_search.Text;
            if (search != "")
            {
                MessageBox.Show("Search success", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchData(txt_search.Text.Trim());
            }
            else
            {
                MessageBox.Show("You have not entered anything yet. Please re-enter", "Notify", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        // Method to search for data in the database based on the student ID
        private void SearchData(string searchValue)
        {
            // Open the database connection
            connection.Open();

            // SQL query to retrieve student information, course name, scores, and class name
            string query = "SELECT " +
               "Students.Student_ID, Students.Student_Name, Students.DateOfBirth, Students.Email, " +
               "CoursesStudent.Course_Name, Grades.Scores, Classes.Class_Name " +
               "FROM Students " +
               "LEFT JOIN Grades ON Students.Student_ID = Grades.Student_ID " +
               "LEFT JOIN CoursesStudent ON Grades.Course_Name = CoursesStudent.Course_Name " +
               "LEFT JOIN Classes ON Grades.Class_Name = Classes.Class_Name " +
               "WHERE Students.Student_ID = @SearchValue";

            // Create and configure SQL command with parameters
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SearchValue", searchValue);

            // Create a DataTable to store the query results
            DataTable Table = new DataTable();
            SqlDataAdapter adapted = new SqlDataAdapter(command);
            adapted.Fill(Table);

            // Display the results in the DataGridView
            dgv_view.DataSource = Table;

            // Close the database connection
            connection.Close();    
        }

        // Event handler for the exit button click
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login Login = new Login();
                Login.ShowDialog();
                this.Dispose();
            }
        }
    }
}
