namespace Grading_Student
{
    partial class GradingStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab_user = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_insert = new Button();
            dgv_view = new DataGridView();
            Student_ID = new DataGridViewTextBoxColumn();
            Student_Name = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Course_Name = new DataGridViewTextBoxColumn();
            Class_Name = new DataGridViewTextBoxColumn();
            Scores = new DataGridViewTextBoxColumn();
            txt_id = new TextBox();
            txt_name = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_scores = new TextBox();
            txt_email = new TextBox();
            btn_exit = new Button();
            lb_error2 = new Label();
            lb_error1 = new Label();
            lb_error = new Label();
            lb_error3 = new Label();
            lb_error4 = new Label();
            lb_error5 = new Label();
            label5 = new Label();
            lb_error6 = new Label();
            dtp_date = new DateTimePicker();
            cb_course = new ComboBox();
            cb_class = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_view).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_user.Location = new Point(51, 19);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(0, 21);
            lab_user.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 96);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Student ID ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 166);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Student Name ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 166);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 5;
            label4.Text = "Course";
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit.Location = new Point(624, 212);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(104, 52);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(756, 212);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(104, 52);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_insert
            // 
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_insert.Location = new Point(624, 146);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(104, 52);
            btn_insert.TabIndex = 10;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // dgv_view
            // 
            dgv_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_view.BackgroundColor = Color.White;
            dgv_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_view.Columns.AddRange(new DataGridViewColumn[] { Student_ID, Student_Name, DateOfBirth, Email, Course_Name, Class_Name, Scores });
            dgv_view.Location = new Point(18, 39);
            dgv_view.Name = "dgv_view";
            dgv_view.RowTemplate.Height = 25;
            dgv_view.Size = new Size(848, 198);
            dgv_view.TabIndex = 11;
            dgv_view.CellDoubleClick += dgv_view_CellClick;
            // 
            // Student_ID
            // 
            Student_ID.DataPropertyName = "Student_ID";
            Student_ID.HeaderText = "Student ID";
            Student_ID.Name = "Student_ID";
            // 
            // Student_Name
            // 
            Student_Name.DataPropertyName = "Student_Name";
            Student_Name.HeaderText = "Student Name";
            Student_Name.Name = "Student_Name";
            // 
            // DateOfBirth
            // 
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "Date of Birth";
            DateOfBirth.Name = "DateOfBirth";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Course_Name
            // 
            Course_Name.DataPropertyName = "Course_Name";
            Course_Name.HeaderText = "Course ";
            Course_Name.Name = "Course_Name";
            // 
            // Class_Name
            // 
            Class_Name.DataPropertyName = "Class_Name";
            Class_Name.HeaderText = "Class ";
            Class_Name.Name = "Class_Name";
            // 
            // Scores
            // 
            Scores.DataPropertyName = "Scores";
            Scores.HeaderText = "Scores";
            Scores.Name = "Scores";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(178, 93);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(136, 23);
            txt_id.TabIndex = 13;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(178, 164);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(136, 23);
            txt_name.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 236);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 96);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 18;
            label8.Text = "Scores";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(343, 96);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 19;
            label9.Text = "Email";
            // 
            // txt_scores
            // 
            txt_scores.Location = new Point(698, 93);
            txt_scores.Name = "txt_scores";
            txt_scores.Size = new Size(162, 23);
            txt_scores.TabIndex = 21;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(424, 93);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(162, 23);
            txt_email.TabIndex = 22;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.Location = new Point(756, 145);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(104, 53);
            btn_exit.TabIndex = 24;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lb_error2
            // 
            lb_error2.AutoSize = true;
            lb_error2.ForeColor = Color.Red;
            lb_error2.Location = new Point(177, 124);
            lb_error2.Name = "lb_error2";
            lb_error2.Size = new Size(0, 15);
            lb_error2.TabIndex = 25;
            // 
            // lb_error1
            // 
            lb_error1.AutoSize = true;
            lb_error1.ForeColor = Color.Red;
            lb_error1.Location = new Point(178, 189);
            lb_error1.Name = "lb_error1";
            lb_error1.Size = new Size(0, 15);
            lb_error1.TabIndex = 26;
            // 
            // lb_error
            // 
            lb_error.AutoSize = true;
            lb_error.ForeColor = Color.Red;
            lb_error.Location = new Point(178, 265);
            lb_error.Name = "lb_error";
            lb_error.Size = new Size(0, 15);
            lb_error.TabIndex = 27;
            // 
            // lb_error3
            // 
            lb_error3.AutoSize = true;
            lb_error3.ForeColor = Color.Red;
            lb_error3.Location = new Point(424, 194);
            lb_error3.Name = "lb_error3";
            lb_error3.Size = new Size(0, 15);
            lb_error3.TabIndex = 28;
            // 
            // lb_error4
            // 
            lb_error4.AutoSize = true;
            lb_error4.ForeColor = Color.Red;
            lb_error4.Location = new Point(698, 119);
            lb_error4.Name = "lb_error4";
            lb_error4.Size = new Size(0, 15);
            lb_error4.TabIndex = 29;
            // 
            // lb_error5
            // 
            lb_error5.AutoSize = true;
            lb_error5.ForeColor = Color.Red;
            lb_error5.Location = new Point(424, 125);
            lb_error5.Name = "lb_error5";
            lb_error5.Size = new Size(0, 15);
            lb_error5.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 233);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 31;
            label5.Text = "Class";
            // 
            // lb_error6
            // 
            lb_error6.AutoSize = true;
            lb_error6.ForeColor = Color.Red;
            lb_error6.Location = new Point(424, 265);
            lb_error6.Name = "lb_error6";
            lb_error6.Size = new Size(0, 15);
            lb_error6.TabIndex = 33;
            // 
            // dtp_date
            // 
            dtp_date.CalendarTitleBackColor = Color.White;
            dtp_date.Location = new Point(177, 230);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(137, 23);
            dtp_date.TabIndex = 34;
            // 
            // cb_course
            // 
            cb_course.FormattingEnabled = true;
            cb_course.Location = new Point(424, 163);
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(162, 23);
            cb_course.TabIndex = 35;
            // 
            // cb_class
            // 
            cb_class.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_class.FormattingEnabled = true;
            cb_class.Location = new Point(424, 228);
            cb_class.Name = "cb_class";
            cb_class.Size = new Size(162, 23);
            cb_class.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(51, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 229);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grading Student";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_view);
            groupBox2.Location = new Point(51, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(885, 265);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "List of student scores";
            // 
            // GradingStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 583);
            Controls.Add(cb_class);
            Controls.Add(cb_course);
            Controls.Add(dtp_date);
            Controls.Add(lb_error6);
            Controls.Add(label5);
            Controls.Add(lb_error5);
            Controls.Add(lb_error4);
            Controls.Add(lb_error3);
            Controls.Add(lb_error1);
            Controls.Add(lb_error2);
            Controls.Add(btn_exit);
            Controls.Add(txt_email);
            Controls.Add(txt_scores);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(btn_insert);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lab_user);
            Controls.Add(groupBox2);
            Controls.Add(lb_error);
            Controls.Add(groupBox1);
            Name = "GradingStudent";
            Text = "Grading Student";
            ((System.ComponentModel.ISupportInitialize)dgv_view).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_user;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_insert;
        private DataGridView dgv_view;
        private TextBox txt_id;
        private TextBox txt_name;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox txt_scores;
        private TextBox txt_email;
        private Button btn_exit;
        private Label lb_error2;
        private Label lb_error1;
        private Label lb_error;
        private Label lb_error3;
        private Label lb_error4;
        private Label lb_error5;
        private Label label5;
        private Label lb_error6;
        private DateTimePicker dtp_date;
        private DataGridViewTextBoxColumn Student_ID;
        private DataGridViewTextBoxColumn Student_Name;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Course_Name;
        private DataGridViewTextBoxColumn Class_Name;
        private DataGridViewTextBoxColumn Scores;
        private ComboBox cb_course;
        private ComboBox cb_class;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}