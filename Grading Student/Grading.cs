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
        public GradingStudent(string UserName)
        {
            InitializeComponent();

            dataAdapter = new SqlDataAdapter();
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");
            lab_user.Text = "User: " + UserName;

            dgv_view.ReadOnly = false;

            LoadData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string id = txt_id.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                lb_error2.Text = "ID can't be blank";
            }
            else
            {
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

            string course = txt_course.Text;
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
            string classes = txt_class.Text;
            if (classes.Equals(""))
            {
                error = error + 1;
                lb_error6.Text = "Class can't be blank";
            }
            if (error == 0)
            {
                connection.Open();
                string insertStudentQuery = "INSERT INTO Students (Student_ID, Student_Name, DateBirth, Email, UserName) " +
                                            "VALUES (@Student_ID, @Student_Name, @DateBirth, @Email, 'Student')";

                SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, connection);
                insertStudentCommand.Parameters.AddWithValue("@Student_ID", id);
                insertStudentCommand.Parameters.AddWithValue("@Student_Name", name);
                insertStudentCommand.Parameters.AddWithValue("@DateBirth", date);
                insertStudentCommand.Parameters.AddWithValue("@Email", email);
                insertStudentCommand.ExecuteNonQuery();

                string insertGradesQuery = "INSERT INTO Grades (Student_ID, StudentCourse_ID, Class_ID, Scores) " +
                           "VALUES (@Student_ID, @StudentCourse_ID, @Class_ID, @Scores)";

                SqlCommand insertGradesCommand = new SqlCommand(insertGradesQuery, connection);
                insertGradesCommand.Parameters.AddWithValue("@Student_ID", id);
                insertGradesCommand.Parameters.AddWithValue("@StudentCourse_ID", course);
                insertGradesCommand.Parameters.AddWithValue("@Class_ID", classes);
                insertGradesCommand.Parameters.AddWithValue("@Scores", scores);
                insertGradesCommand.ExecuteNonQuery();

                MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                LoadData();
            }
        }

        private void LoadData()
        {
            string queryCombined = "SELECT " +
                               "Students.Student_ID, Students.Student_Name, Students.DateBirth, Students.Email, " +
                               "StudentCourses.Course_Name, Grades.Scores, Classes.Class_Name " +
                               "FROM Students " +
                               "LEFT JOIN Grades ON Students.Student_ID = Grades.Student_ID " +
                               "LEFT JOIN StudentCourses ON Grades.StudentCourse_ID = StudentCourses.StudentCourse_ID " +
                               "LEFT JOIN Classes ON Grades.Class_ID = Classes.Class_ID";

            SqlCommand commandCombined = new SqlCommand(queryCombined, connection);
            DataTable combinedTable = new DataTable();
            SqlDataAdapter adapterCombined = new SqlDataAdapter(commandCombined);
            adapterCombined.Fill(combinedTable);

            dgv_view.DataSource = combinedTable;
            SharedData.Data = (DataTable)dgv_view.DataSource;
            dgv_view.Refresh();

            txt_id.Clear();
            txt_name.Clear();
            dtp_date.Value = DateTime.Now;
            txt_course.Clear();
            txt_scores.Clear();
            txt_class.Clear();
            txt_email.Clear();

            connection.Close();
        }

        private void dgv_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_view.Rows[e.RowIndex];

                txt_id.Text = row.Cells["Student_ID"].Value.ToString();
                txt_name.Text = row.Cells["Student_Name"].Value.ToString();
                dtp_date.Value = Convert.ToDateTime(row.Cells["DateBirth"].Value);
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_course.Text = row.Cells["Course_Name"].Value.ToString();
                txt_scores.Text = row.Cells["Scores"].Value.ToString();
                txt_class.Text = row.Cells["Class_Name"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_view.SelectedRows.Count > 0)
            {
                int studentID = int.Parse(txt_id.Text);
                string studentName = txt_name.Text;
                DateTime dateOfBirth = dtp_date.Value;
                string email = txt_email.Text;
                int course = int.Parse(txt_course.Text);
                int scores = int.Parse(txt_scores.Text);
                int className = int.Parse(txt_class.Text);

                int selectedRowID = dgv_view.SelectedRows[0].Index;

                dgv_view.Rows[selectedRowID].Cells["Student_ID"].Value = studentID;
                dgv_view.Rows[selectedRowID].Cells["Student_Name"].Value = studentName;
                dgv_view.Rows[selectedRowID].Cells["DateBirth"].Value = dateOfBirth;
                dgv_view.Rows[selectedRowID].Cells["Email"].Value = email;
                dgv_view.Rows[selectedRowID].Cells["Course_Name"].Value = course;
                dgv_view.Rows[selectedRowID].Cells["Scores"].Value = scores;
                dgv_view.Rows[selectedRowID].Cells["Class_Name"].Value = className;

                connection.Open();

                string updateStudentQuery = "UPDATE Students SET Student_Name = @Student_Name, DateBirth = @DateBirth, Email = @Email WHERE Student_ID = @Student_ID";
                SqlCommand updateStudentCommand = new SqlCommand(updateStudentQuery, connection);
                updateStudentCommand.Parameters.AddWithValue("@Student_ID", studentID);
                updateStudentCommand.Parameters.AddWithValue("@Student_Name", studentName);
                updateStudentCommand.Parameters.AddWithValue("@DateBirth", dateOfBirth);
                updateStudentCommand.Parameters.AddWithValue("@Email", email);
                updateStudentCommand.ExecuteNonQuery();

                string updateGradesQuery = "UPDATE Grades SET StudentCourse_ID = @StudentCourse_ID, Class_ID = @Class_ID, Scores = @Scores WHERE Student_ID = @Student_ID";
                SqlCommand updateGradesCommand = new SqlCommand(updateGradesQuery, connection);
                updateGradesCommand.Parameters.AddWithValue("@Student_ID", studentID);
                updateGradesCommand.Parameters.AddWithValue("@StudentCourse_ID", course);
                updateGradesCommand.Parameters.AddWithValue("@Class_ID", className);
                updateGradesCommand.Parameters.AddWithValue("@Scores", scores);
                updateGradesCommand.ExecuteNonQuery();

                MessageBox.Show("Student information has been updated successfully.", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                LoadData();
            }
            else
            {
                MessageBox.Show("No students have been selected yet!. Please select the student you want to edit", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_view.SelectedRows.Count > 0)
            {
                string studentID = dgv_view.SelectedRows[0].Cells["Student_ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    connection.Open();

                    DeleteGrades(studentID);

                    DeleteStudent(studentID);

                    connection.Close();

                    MessageBox.Show("Student has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
            }
        }

        private void DeleteGrades(string studentID)
        {
            SqlCommand checkGradesCommand = new SqlCommand("SELECT COUNT(*) FROM Grades WHERE Student_ID = @Student_ID", connection);
            checkGradesCommand.Parameters.AddWithValue("@Student_ID", studentID);
            int relatedGradesCount = (int)checkGradesCommand.ExecuteScalar();

            string deleteGradesQuery = "DELETE FROM Grades WHERE Student_ID = @Student_ID";
            SqlCommand deleteGradesCommand = new SqlCommand(deleteGradesQuery, connection);
            deleteGradesCommand.Parameters.AddWithValue("@Student_ID", studentID);
            deleteGradesCommand.ExecuteNonQuery();
        }

        private void DeleteStudent(string studentID)
        {
            string deleteStudentQuery = "DELETE FROM Students WHERE Student_ID = @Student_ID";
            SqlCommand deleteStudentCommand = new SqlCommand(deleteStudentQuery, connection);
            deleteStudentCommand.Parameters.AddWithValue("@Student_ID", studentID);
            deleteStudentCommand.ExecuteNonQuery();
        }

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




