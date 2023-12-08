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

            // Initialize database connection
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");

            // Add items to the role combo box
            cb_role.Items.Add("Student");
            cb_role.Items.Add("Teacher");
        }

        // Event handler for the login button click
        private void btn_login_Click(object sender, EventArgs e)
        {
            Login open = new Login();
            open.Show();
            this.Hide();
        }

        // Event handler for the register button click
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Event handler for the register button click
        private void btn_register_Click(object sender, EventArgs e)
        {   
            string UserName = txt_name.Text;
            string UserRole = cb_role.Text;
            string Pass = txt_pass.Text;
            string Email = txt_email.Text;

            // Event handler for the register button click
            if (txt_pass.Text != txt_rtpass.Text)
            {
                MessageBox.Show("Passwords do not match!!!. Please re-enter", "Notify", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the username already exists in the database
            string QueryCheck = "SELECT COUNT(*) FROM StudentLogin WHERE UserName = @UserName";

            SqlCommand commandCheck = new SqlCommand(QueryCheck, connection);
            commandCheck.Parameters.AddWithValue("@UserName", UserName);
            connection.Open();
            int usernameCount = Convert.ToInt32(commandCheck.ExecuteScalar());
            connection.Close();
            if (usernameCount > 0)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert user data into the appropriate table based on the selected role
            string queryStudent = "INSERT INTO StudentLogin (UserName, Pass, Email, UserRole) VALUES (@UserName, @Pass, @Email, @UserRole)";
            string queryTeacher = "INSERT INTO TeacherLogin (UserName, Pass, Email, UserRole) VALUES (@UserName, @Pass, @Email, @UserRole)";
            
            connection.Open();

            if (cb_role.Text == "Student")
            {
                // Insert data into the StudentLogin table
                SqlCommand commandStudent = new SqlCommand(queryStudent, connection);
                commandStudent.Parameters.AddWithValue("@UserName", UserName);
                commandStudent.Parameters.AddWithValue("@Pass", Pass);
                commandStudent.Parameters.AddWithValue("@Email", Email);
                commandStudent.Parameters.AddWithValue("@UserRole", UserRole);

                commandStudent.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the Login form and hide the current form
                Login open = new Login();
                open.Show();
                this.Hide();
            }
            else if (cb_role.Text == "Teacher")
            {

                // Insert data into the TeacherLogin table
                SqlCommand commandTeacher = new SqlCommand(queryTeacher, connection);
                commandTeacher.Parameters.AddWithValue("@UserName", UserName);
                commandTeacher.Parameters.AddWithValue("@Pass", Pass);
                commandTeacher.Parameters.AddWithValue("@Email", Email);
                commandTeacher.Parameters.AddWithValue("@UserRole", UserRole);

                commandTeacher.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the Login form and hide the current form
                Login open = new Login();
                open.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the account name you want to register!, 'Teacher' or 'Student'", "Notify", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            connection.Close();
        }

        // Event handler for the show/hide password checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show1.Checked)
            {
                txt_pass.PasswordChar = '\0'; // Show password
            }
            else
            {
                txt_pass.PasswordChar = '*'; // Hide password
            }
        }

        // Event handler for the show/hide password checkbox for password confirmation
        private void ckb_show2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show2.Checked)
            {
                txt_rtpass.PasswordChar = '\0'; // Show password
            }
            else
            {
                txt_rtpass.PasswordChar = '*'; // Hide password
            }
        }
    }
}

