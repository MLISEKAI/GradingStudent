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
        public ViewGrading(string UserName)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");

            lab_user.Text = "User: " + UserName;

            LoadData();
        }
        
        private void LoadData()
        {
            connection.Open();

            string query = "SELECT " +
                                "Students.Student_ID, Students.Student_Name, Students.DateBirth, Students.Email, " +
                                "StudentCourses.Course_Name, Grades.Scores, Classes.Class_Name " +
                                "FROM Students " +
                                "LEFT JOIN Grades ON Students.Student_ID = Grades.Student_ID " +
                                "LEFT JOIN StudentCourses ON Grades.StudentCourse_ID = StudentCourses.StudentCourse_ID " +
                                "LEFT JOIN Classes ON Grades.Class_ID = Classes.Class_ID";

            SqlCommand command = new SqlCommand(query, connection);
            DataTable Table = new DataTable();
            SqlDataAdapter adapted = new SqlDataAdapter(command);
            adapted.Fill(Table);

            dgv_view.DataSource = Table;

            connection.Close();
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
