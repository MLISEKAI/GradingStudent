using Grading_Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace Product_Management
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            
            // Initialize database connection
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");

            // Add items to the user role combo box
            cb_name.Items.Add("Student");
            cb_name.Items.Add("Teacher");
        }

        // Event handler for the login button click
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Retrieve user input data
            string UserName = cb_name.Text;
            string Pass = txt_pass.Text;

            // Check if the database connection is closed and open if necessary
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Check if the database connection is successfully opened
            if (connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Unable to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the database connection is successfully opened
            string Query = "SELECT * FROM StudentLogin WHERE UserName = @UserName AND Pass = @Password " +
                           "UNION " +
                           "SELECT * FROM TeacherLogin WHERE UserName = @UserName AND Pass = @Password";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Pass);

            // Execute the SQL query and read the results
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Retrieve the user role from the database
                string Role = reader["UserRole"].ToString();

                // Open the appropriate form based on the user role
                if (Role.Equals("Student"))
                {
                    MessageBox.Show("Successful login as Student", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewGrading Open = new ViewGrading(Role);
                    Open.Show();
                    this.Hide();
                }
                else if (Role.Equals("Teacher"))
                {
                    MessageBox.Show("Successful login as Teacher", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GradingStudent Open = new GradingStudent(Role);
                    Open.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password. Please try again.", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Close the database connection
            connection.Close();
        }

        // Event handler for the exit button click
        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box before exiting the application
            if (MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ckb_show_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler for the show/hide password checkbox
            if (ckb_show.Checked)
            { 
                txt_pass.PasswordChar = '\0'; // Show password
            }
            else
            {
                txt_pass.PasswordChar = '*';  // Hide password
            }
        }

        // Event handler for the register button click
        private void btn_register_Click(object sender, EventArgs e)
        {
            // Open the Register form and hide the current form
            Register open = new Register();
            open.Show();
            this.Hide();
        }


    }
}


