using Grading_Student;
using Microsoft.VisualBasic.Devices;
using Product_Management;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grading_Student
{
    public partial class GradingStudent : Form
    {

        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;

        public GradingStudent(string Role)
        {
            InitializeComponent();

            // Initialize database connection and data adapter
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");
            dataAdapter = new SqlDataAdapter();

            // Display the user role in a label
            lab_user.Text = "User: " + Role;

            // Set up the initial state of the form
            dgv_view.ReadOnly = false;
            cb_course.Items.Add("Database Design & Development");
            cb_class.Items.Add("IT");

            // Load data into the DataGridView
            LoadData();
        }

        // Event handler for the insert button click
        private void btn_insert_Click(object sender, EventArgs e)
        {
            int error = 0;

            // Retrieve input values from the form
            string id = txt_id.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                lb_error2.Text = "ID can't be blank";
            }
            else
            {
                // Check if the ID already exists in the database
                string Query = "SELECT * FROM Students where Student_ID = @Student_ID";
                connection.Open();
                SqlCommand commandCheck = new SqlCommand(Query, connection);
                commandCheck.Parameters.AddWithValue("@Student_ID", id);
                SqlDataReader reader = commandCheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lb_error2.Text = "The ID value already exists, please re-enter";
                }
                else
                {
                    lb_error2.Text = "";
                }
                connection.Close();
            }

            string name = txt_name.Text;
            if (name.Equals(""))
            {
                error = error + 1;
                lb_error1.Text = "Name can't be blank";
            }
            else
            {
                lb_error1.Text = "";
            }
            DateTime date = dtp_date.Value;
            if (date == DateTime.MinValue)
            {
                error = error + 1;
                lb_error.Text = "Date of birth can't be empty";
            
            }
            else
            {
                lb_error.Text = "";
            }

            string course = cb_course.Text;
            if (course.Equals(""))
            {
                error = error + 1;
                lb_error3.Text = "Course can't be blank";
            }
            else
            {
                lb_error3.Text = "";
            }
            string scores = txt_scores.Text;
            if (scores.Equals(""))
            {
                error = error + 1;
                lb_error4.Text = "Scores can't be blank";
            }
            else
            {
                lb_error4.Text = "";
            }
            string email = txt_email.Text;
            if (email.Equals(""))
            {
                error = error + 1;
                lb_error5.Text = "Email can't be blank";
            }
            else
            {
                lb_error5.Text = "";
            }
            string classes = cb_class.Text;
            if (classes.Equals(""))
            {
                error = error + 1;
                lb_error6.Text = "Class can't be blank";
            }
            else
            {
                lb_error6.Text = "";
            }

            // If there are no errors, insert the data into the database
            if (error == 0)
            {
                // Open the database connection
                connection.Open();

                // Insert data into the Students table
                string insertStudentQuery = "INSERT INTO Students (Student_ID, Student_Name, DateOfBirth, Email, UserName) " +
                                            "VALUES (@Student_ID, @Student_Name, @DateOfBirth, @Email, 'Student')";

                SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, connection);
                insertStudentCommand.Parameters.AddWithValue("@Student_ID", id);
                insertStudentCommand.Parameters.AddWithValue("@Student_Name", name);
                insertStudentCommand.Parameters.AddWithValue("@DateOfBirth", date);
                insertStudentCommand.Parameters.AddWithValue("@Email", email);
                insertStudentCommand.ExecuteNonQuery();

                // Insert data into the Grades table
                string insertGradesQuery = "INSERT INTO Grades (Student_ID, Course_Name, Class_Name, Scores) " +
                           "VALUES (@Student_ID, @Course_Name, @Class_Name, @Scores)";

                SqlCommand insertGradesCommand = new SqlCommand(insertGradesQuery, connection);
                insertGradesCommand.Parameters.AddWithValue("@Student_ID", id);
                insertGradesCommand.Parameters.AddWithValue("@Course_Name", course);
                insertGradesCommand.Parameters.AddWithValue("@Class_Name", classes);
                insertGradesCommand.Parameters.AddWithValue("@Scores", scores);
                insertGradesCommand.ExecuteNonQuery();

                MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the database connection and reload data into the DataGridView
                connection.Close();
                LoadData();
            }
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            string queryCombined = "SELECT " +
               "Students.Student_ID, Students.Student_Name, Students.DateOfBirth, Students.Email, " +
               "CoursesStudent.Course_Name, Grades.Scores, Classes.Class_Name " +
               "FROM Students " +
               "LEFT JOIN Grades ON Students.Student_ID = Grades.Student_ID " +
               "LEFT JOIN CoursesStudent ON Grades.Course_Name = CoursesStudent.Course_Name " +
               "LEFT JOIN Classes ON Grades.Class_Name = Classes.Class_Name ";

            SqlCommand commandCombined = new SqlCommand(queryCombined, connection);
            DataTable combinedTable = new DataTable();
            SqlDataAdapter adapterCombined = new SqlDataAdapter(commandCombined);
            adapterCombined.Fill(combinedTable);

            dgv_view.DataSource = combinedTable;
            SharedData.Data = (DataTable)dgv_view.DataSource;
            dgv_view.Refresh();

            // Clear the input fields
            txt_id.Clear();
            txt_name.Clear();
            dtp_date.Value = DateTime.Now;
            cb_course.Text = "";
            txt_scores.Clear();
            cb_class.Text = "";
            txt_email.Clear();

            // Close the database connection
            connection.Close();
        }

        // Event handler for the DataGridView cell click
        private void dgv_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve data from the selected row and populate the input fields
                DataGridViewRow row = dgv_view.Rows[e.RowIndex];
                txt_id.Text = row.Cells["Student_ID"].Value.ToString();
                txt_name.Text = row.Cells["Student_Name"].Value.ToString();
                dtp_date.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                txt_email.Text = row.Cells["Email"].Value.ToString();
                cb_course.Text = row.Cells["Course_Name"].Value.ToString();
                txt_scores.Text = row.Cells["Scores"].Value.ToString();
                cb_class.Text = row.Cells["Class_Name"].Value.ToString();
            }
        }

        // Event handler for the edit button click
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_view.SelectedRows.Count > 0)
            {
                // Retrieve data from the input fields
                int studentID = int.Parse(txt_id.Text);
                string studentName = txt_name.Text;
                DateTime dateOfBirth = dtp_date.Value;
                string email = txt_email.Text;
                string course = cb_course.Text;
                int scores = int.Parse(txt_scores.Text);
                string className = cb_class.Text;

                // Retrieve the index of the selected row
                int selectedRowID = dgv_view.SelectedRows[0].Index;

                // Update the data in the DataGridView
                dgv_view.Rows[selectedRowID].Cells["Student_ID"].Value = studentID;
                dgv_view.Rows[selectedRowID].Cells["Student_Name"].Value = studentName;
                dgv_view.Rows[selectedRowID].Cells["DateOfBirth"].Value = dateOfBirth;
                dgv_view.Rows[selectedRowID].Cells["Email"].Value = email;
                dgv_view.Rows[selectedRowID].Cells["Course_Name"].Value = course;
                dgv_view.Rows[selectedRowID].Cells["Scores"].Value = scores;
                dgv_view.Rows[selectedRowID].Cells["Class_Name"].Value = className;

                // Open the database connection
                connection.Open();

                // Update the data in the Students table
                string updateStudentQuery = "UPDATE Students SET Student_Name = @Student_Name, DateOfBirth = @DateOfBirth, " +
                    "Email = @Email WHERE Student_ID = @Student_ID";
                SqlCommand updateStudentCommand = new SqlCommand(updateStudentQuery, connection);
                updateStudentCommand.Parameters.AddWithValue("@Student_ID", studentID);
                updateStudentCommand.Parameters.AddWithValue("@Student_Name", studentName);
                updateStudentCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                updateStudentCommand.Parameters.AddWithValue("@Email", email);
                updateStudentCommand.ExecuteNonQuery();

                // Update the data in the Grades table
                string updateGradesQuery = "UPDATE Grades SET Course_Name = @Course_Name, Class_Name = @Class_Name, " +
                    "Scores = @Scores WHERE Student_ID = @Student_ID";
                SqlCommand updateGradesCommand = new SqlCommand(updateGradesQuery, connection);
                updateGradesCommand.Parameters.AddWithValue("@Student_ID", studentID);
                updateGradesCommand.Parameters.AddWithValue("@Course_Name", course);
                updateGradesCommand.Parameters.AddWithValue("@Class_Name", className);
                updateGradesCommand.Parameters.AddWithValue("@Scores", scores);
                updateGradesCommand.ExecuteNonQuery();

                MessageBox.Show("Student information has been updated successfully.", "Notify", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Close the database connection and reload data into the DataGridView
                connection.Close();
                LoadData();
            }
            else
            {
                MessageBox.Show("No students have been selected yet!. Please select the student you want to edit", "Notify", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for the delete button click
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_view.SelectedRows.Count > 0)
            {
                // Get the student ID of the selected row
                string studentID = dgv_view.SelectedRows[0].Cells["Student_ID"].Value.ToString();
                
                // Confirm the deletion with a dialog box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Notify", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    connection.Open();

                    // Confirm the deletion with a dialog box
                    DeleteGrades(studentID);

                    // Delete the student
                    DeleteStudent(studentID);

                    connection.Close();

                    // Display a success message
                    MessageBox.Show("Student has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data in the DataGridView
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Students have not been selected to delete. Please select the student you want to delete", "Notify", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to delete grades associated with a student
        private void DeleteGrades(string studentID)
        {
            // Check the number of related grades
            SqlCommand checkGradesCommand = new SqlCommand("SELECT COUNT(*) FROM Grades WHERE Student_ID = @Student_ID", connection);
            checkGradesCommand.Parameters.AddWithValue("@Student_ID", studentID);
            int relatedGradesCount = (int)checkGradesCommand.ExecuteScalar();

            // Delete grades if there are any   
            string deleteGradesQuery = "DELETE FROM Grades WHERE Student_ID = @Student_ID";
            SqlCommand deleteGradesCommand = new SqlCommand(deleteGradesQuery, connection);
            deleteGradesCommand.Parameters.AddWithValue("@Student_ID", studentID);
            deleteGradesCommand.ExecuteNonQuery();
        }

        // Method to delete a student
        private void DeleteStudent(string studentID)
        {
            string deleteStudentQuery = "DELETE FROM Students WHERE Student_ID = @Student_ID";
            SqlCommand deleteStudentCommand = new SqlCommand(deleteStudentQuery, connection);
            deleteStudentCommand.Parameters.AddWithValue("@Student_ID", studentID);
            deleteStudentCommand.ExecuteNonQuery();
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




