using Product_Management;
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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grading_Student
{
    public partial class Register : Form
    {
        private SqlConnection connection;
        public Register()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");
            cb_name.Items.Add("Student");
            cb_name.Items.Add("Teacher");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login open = new Login();
            open.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string UserName = cb_name.Text;
            string Pass = txt_pass.Text;
            string Email = txt_email.Text;

            string queryStudent = "UPDATE StudentLogin SET UserName = @UserName, Pass = @Pass, Email = @Email, UserRole = @UserRole";
            string queryTeacher = "UPDATE TeacherLogin SET UserName = @UserName, Pass = @Pass, Email = @Email, UserRole = @UserRole";

            if (cb_name.Text == "Student")
            {
                SqlCommand commandStudent = new SqlCommand(queryStudent, connection);
                commandStudent.Parameters.AddWithValue("@UserName", UserName);
                commandStudent.Parameters.AddWithValue("@Pass", Pass);
                commandStudent.Parameters.AddWithValue("@Email", Email);
                commandStudent.Parameters.AddWithValue("@UserRole", UserName);

                commandStudent.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login open = new Login();
                open.Show();
                this.Hide();
            }
            else if (cb_name.Text == "Teacher")
            {
                SqlCommand commandTeacher = new SqlCommand(queryTeacher, connection);
                commandTeacher.Parameters.AddWithValue("@UserName", UserName);
                commandTeacher.Parameters.AddWithValue("@Pass", Pass);
                commandTeacher.Parameters.AddWithValue("@Email", Email);
                commandTeacher.Parameters.AddWithValue("@UserRole", UserName);

                commandTeacher.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login open = new Login();
                open.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the account name you want to register!, 'Teacher' or 'Student'", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            connection.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show1.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void ckb_show2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show2.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }
    }
}

