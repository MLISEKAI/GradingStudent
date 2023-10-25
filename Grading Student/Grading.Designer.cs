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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_insert = new Button();
            dgv_view = new DataGridView();
            Student_ID = new DataGridViewTextBoxColumn();
            Student_Name = new DataGridViewTextBoxColumn();
            DateBirth = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Course_Name = new DataGridViewTextBoxColumn();
            Class_Name = new DataGridViewTextBoxColumn();
            Scores = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_course = new TextBox();
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
            txt_class = new TextBox();
            lb_error6 = new Label();
            dtp_date = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_view).BeginInit();
            SuspendLayout();
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_user.Location = new Point(51, 34);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(0, 21);
            lab_user.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(354, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 37);
            label1.TabIndex = 2;
            label1.Text = "Grading Student ";
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
            btn_edit.Location = new Point(634, 219);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(104, 49);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(758, 219);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 49);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_insert
            // 
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_insert.Location = new Point(634, 151);
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
            dgv_view.Columns.AddRange(new DataGridViewColumn[] { Student_ID, Student_Name, DateBirth, Email, Course_Name, Class_Name, Scores });
            dgv_view.Location = new Point(51, 355);
            dgv_view.Name = "dgv_view";
            dgv_view.RowTemplate.Height = 25;
            dgv_view.Size = new Size(836, 198);
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
            // DateBirth
            // 
            DateBirth.DataPropertyName = "DateBirth";
            DateBirth.HeaderText = "Date of Birth";
            DateBirth.Name = "DateBirth";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(333, 290);
            label7.Name = "label7";
            label7.Size = new Size(264, 37);
            label7.TabIndex = 12;
            label7.Text = "List of student scores";
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
            // txt_course
            // 
            txt_course.Location = new Point(424, 163);
            txt_course.Name = "txt_course";
            txt_course.Size = new Size(162, 23);
            txt_course.TabIndex = 15;
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
            btn_exit.Location = new Point(758, 151);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(102, 53);
            btn_exit.TabIndex = 24;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lb_error2
            // 
            lb_error2.AutoSize = true;
            lb_error2.Location = new Point(177, 124);
            lb_error2.Name = "lb_error2";
            lb_error2.Size = new Size(0, 15);
            lb_error2.TabIndex = 25;
            // 
            // lb_error1
            // 
            lb_error1.AutoSize = true;
            lb_error1.Location = new Point(178, 189);
            lb_error1.Name = "lb_error1";
            lb_error1.Size = new Size(0, 15);
            lb_error1.TabIndex = 26;
            // 
            // lb_error
            // 
            lb_error.AutoSize = true;
            lb_error.Location = new Point(178, 265);
            lb_error.Name = "lb_error";
            lb_error.Size = new Size(0, 15);
            lb_error.TabIndex = 27;
            // 
            // lb_error3
            // 
            lb_error3.AutoSize = true;
            lb_error3.Location = new Point(424, 194);
            lb_error3.Name = "lb_error3";
            lb_error3.Size = new Size(0, 15);
            lb_error3.TabIndex = 28;
            // 
            // lb_error4
            // 
            lb_error4.AutoSize = true;
            lb_error4.Location = new Point(698, 119);
            lb_error4.Name = "lb_error4";
            lb_error4.Size = new Size(0, 15);
            lb_error4.TabIndex = 29;
            // 
            // lb_error5
            // 
            lb_error5.AutoSize = true;
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
            // txt_class
            // 
            txt_class.Location = new Point(424, 228);
            txt_class.Name = "txt_class";
            txt_class.Size = new Size(162, 23);
            txt_class.TabIndex = 32;
            // 
            // lb_error6
            // 
            lb_error6.AutoSize = true;
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
            // GradingStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 636);
            Controls.Add(dtp_date);
            Controls.Add(lb_error6);
            Controls.Add(txt_class);
            Controls.Add(label5);
            Controls.Add(lb_error5);
            Controls.Add(lb_error4);
            Controls.Add(lb_error3);
            Controls.Add(lb_error);
            Controls.Add(lb_error1);
            Controls.Add(lb_error2);
            Controls.Add(btn_exit);
            Controls.Add(txt_email);
            Controls.Add(txt_scores);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_course);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label7);
            Controls.Add(dgv_view);
            Controls.Add(btn_insert);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lab_user);
            Name = "GradingStudent";
            Text = "Grading Student";
            ((System.ComponentModel.ISupportInitialize)dgv_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_user;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_insert;
        private DataGridView dgv_view;
        private Label label7;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_course;
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
        private TextBox txt_class;
        private Label lb_error6;
        private DateTimePicker dtp_date;
        private DataGridViewTextBoxColumn Student_ID;
        private DataGridViewTextBoxColumn Student_Name;
        private DataGridViewTextBoxColumn DateBirth;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Course_Name;
        private DataGridViewTextBoxColumn Class_Name;
        private DataGridViewTextBoxColumn Scores;
    }
}