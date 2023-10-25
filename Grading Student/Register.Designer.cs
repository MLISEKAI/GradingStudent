namespace Grading_Student
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            btn_exit = new Button();
            btn_register = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ckb_show2 = new CheckBox();
            label5 = new Label();
            btn_login = new Button();
            label6 = new Label();
            txt_rtpass = new TextBox();
            txt_pass = new TextBox();
            txt_email = new TextBox();
            ckb_show1 = new CheckBox();
            cb_name = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1019, 584);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.White;
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.Location = new Point(810, 389);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(106, 56);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.White;
            btn_register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(647, 389);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(106, 56);
            btn_register.TabIndex = 2;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(622, 64);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 3;
            label1.Text = "Register Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(540, 160);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(540, 217);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(540, 324);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // ckb_show2
            // 
            ckb_show2.AutoSize = true;
            ckb_show2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_show2.Location = new Point(922, 278);
            ckb_show2.Margin = new Padding(6);
            ckb_show2.Name = "ckb_show2";
            ckb_show2.Size = new Size(15, 14);
            ckb_show2.TabIndex = 7;
            ckb_show2.UseVisualStyleBackColor = true;
            ckb_show2.CheckedChanged += ckb_show2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(102, 516);
            label5.Name = "label5";
            label5.Size = new Size(266, 21);
            label5.TabIndex = 8;
            label5.Text = "If you have an account. Please log in?";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.White;
            btn_login.Location = new Point(12, 511);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(84, 35);
            btn_login.TabIndex = 9;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(540, 271);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 10;
            label6.Text = "Reenter password";
            // 
            // txt_rtpass
            // 
            txt_rtpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_rtpass.Location = new Point(731, 267);
            txt_rtpass.Name = "txt_rtpass";
            txt_rtpass.PasswordChar = '*';
            txt_rtpass.Size = new Size(185, 29);
            txt_rtpass.TabIndex = 12;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(731, 213);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(185, 29);
            txt_pass.TabIndex = 13;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(731, 320);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(182, 29);
            txt_email.TabIndex = 14;
            // 
            // ckb_show1
            // 
            ckb_show1.AutoSize = true;
            ckb_show1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_show1.Location = new Point(922, 224);
            ckb_show1.Margin = new Padding(6);
            ckb_show1.Name = "ckb_show1";
            ckb_show1.Size = new Size(15, 14);
            ckb_show1.TabIndex = 15;
            ckb_show1.UseVisualStyleBackColor = true;
            ckb_show1.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // cb_name
            // 
            cb_name.BackColor = Color.White;
            cb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_name.FormattingEnabled = true;
            cb_name.Location = new Point(731, 160);
            cb_name.Name = "cb_name";
            cb_name.Size = new Size(185, 29);
            cb_name.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 558);
            Controls.Add(cb_name);
            Controls.Add(ckb_show1);
            Controls.Add(txt_email);
            Controls.Add(txt_pass);
            Controls.Add(txt_rtpass);
            Controls.Add(label6);
            Controls.Add(btn_login);
            Controls.Add(label5);
            Controls.Add(ckb_show2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(btn_exit);
            Controls.Add(pictureBox1);
            Name = "Register";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_exit;
        private Button btn_register;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox ckb_show2;
        private Label label5;
        private Button btn_login;
        private Label label6;
        private TextBox txt_rtpass;
        private TextBox txt_pass;
        private TextBox txt_email;
        private CheckBox ckb_show1;
        private ComboBox cb_name;
    }
}