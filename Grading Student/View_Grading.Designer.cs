namespace Grading_Student
{
    partial class ViewGrading
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
            dgv_view = new DataGridView();
            Student_ID = new DataGridViewTextBoxColumn();
            Student_Name = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Course_Name = new DataGridViewTextBoxColumn();
            Class_Name = new DataGridViewTextBoxColumn();
            Scores = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btn_exit = new Button();
            lab_user = new Label();
            txt_search = new TextBox();
            label2 = new Label();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_view).BeginInit();
            SuspendLayout();
            // 
            // dgv_view
            // 
            dgv_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_view.BackgroundColor = Color.White;
            dgv_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_view.Columns.AddRange(new DataGridViewColumn[] { Student_ID, Student_Name, DateOfBirth, Email, Course_Name, Class_Name, Scores });
            dgv_view.Location = new Point(33, 214);
            dgv_view.Name = "dgv_view";
            dgv_view.RowTemplate.Height = 25;
            dgv_view.Size = new Size(995, 155);
            dgv_view.TabIndex = 0;
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
            Class_Name.HeaderText = "Class";
            Class_Name.Name = "Class_Name";
            // 
            // Scores
            // 
            Scores.DataPropertyName = "Scores";
            Scores.HeaderText = "Scores";
            Scores.Name = "Scores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(390, 40);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 1;
            label1.Text = "List of student scores";
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.Location = new Point(931, 389);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(97, 31);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_user.Location = new Point(55, 40);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(0, 21);
            lab_user.TabIndex = 3;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(156, 109);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(112, 29);
            txt_search.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 6;
            label2.Text = "Student ID";
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(33, 161);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 31);
            btn_search.TabIndex = 7;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // ViewGrading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 441);
            Controls.Add(btn_search);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(lab_user);
            Controls.Add(btn_exit);
            Controls.Add(label1);
            Controls.Add(dgv_view);
            Name = "ViewGrading";
            Text = "View Grading";
            ((System.ComponentModel.ISupportInitialize)dgv_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_view;
        private Label label1;
        private Button btn_exit;
        private Label lab_user;
        private TextBox txt_search;
        private Label label2;
        private Button btn_search;
        private DataGridViewTextBoxColumn Student_ID;
        private DataGridViewTextBoxColumn Student_Name;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Course_Name;
        private DataGridViewTextBoxColumn Class_Name;
        private DataGridViewTextBoxColumn Scores;
    }
}