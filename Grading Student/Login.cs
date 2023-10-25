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

namespace Product_Management
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-BPU3QMV\\MSSQL2022;Initial Catalog=GradingStudents;Integrated Security=True");
            cb_name.Items.Add("Student");
            cb_name.Items.Add("Teacher");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string UserName = cb_name.Text;
            string Pass = txt_pass.Text;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Unable to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Query = "SELECT * FROM StudentLogin WHERE UserName = @UserName AND Pass = @Password " +
                       "UNION " +
                       "SELECT * FROM TeacherLogin WHERE UserName = @UserName AND Pass = @Password";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Pass);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string Role = reader["UserRole"].ToString();

                if (Role.Equals("Student"))
                {
                    MessageBox.Show("Successful login", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewGrading Open = new ViewGrading(UserName);                   
                    Open.Show();
                    this.Hide();
                }
                else if (Role.Equals("Teacher"))
                {
                    MessageBox.Show("Successful login", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GradingStudent Open = new GradingStudent(UserName);
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
            connection.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ckb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register open = new Register();
            open.Show();
            this.Hide();
        }


    }
}


