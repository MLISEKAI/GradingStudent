namespace Product_Management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_exit = new Button();
            btn_login = new Button();
            ckb_show = new CheckBox();
            txt_pass = new TextBox();
            pictureBox1 = new PictureBox();
            btn_register = new Button();
            label5 = new Label();
            cb_name = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(354, 153);
            label1.Name = "label1";
            label1.Size = new Size(289, 54);
            label1.TabIndex = 0;
            label1.Text = "Login Account ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(284, 229);
            label2.Name = "label2";
            label2.Size = new Size(155, 37);
            label2.TabIndex = 1;
            label2.Text = "User Name ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(284, 299);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.White;
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.Location = new Point(516, 403);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(115, 65);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.White;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(342, 403);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(111, 65);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // ckb_show
            // 
            ckb_show.AutoSize = true;
            ckb_show.BackColor = Color.White;
            ckb_show.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_show.ForeColor = Color.Black;
            ckb_show.Location = new Point(460, 351);
            ckb_show.Name = "ckb_show";
            ckb_show.Size = new Size(127, 23);
            ckb_show.TabIndex = 5;
            ckb_show.Text = "Show password ";
            ckb_show.UseVisualStyleBackColor = false;
            ckb_show.CheckedChanged += ckb_show_CheckedChanged;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.White;
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(460, 307);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(202, 29);
            txt_pass.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -25);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1060, 690);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.White;
            btn_register.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(944, 619);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(104, 32);
            btn_register.TabIndex = 9;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(609, 624);
            label5.Name = "label5";
            label5.Size = new Size(320, 21);
            label5.TabIndex = 11;
            label5.Text = "If you don't have an account. Please register?";
            // 
            // cb_name
            // 
            cb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_name.FormattingEnabled = true;
            cb_name.Location = new Point(460, 237);
            cb_name.Name = "cb_name";
            cb_name.Size = new Size(202, 29);
            cb_name.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 666);
            Controls.Add(cb_name);
            Controls.Add(label5);
            Controls.Add(btn_register);
            Controls.Add(txt_pass);
            Controls.Add(ckb_show);
            Controls.Add(btn_login);
            Controls.Add(btn_exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_exit;
        private Button btn_login;
        private CheckBox ckb_show;
        private TextBox txt_pass;
        private PictureBox pictureBox1;
        private Button btn_register;
        private Label label5;
        private ComboBox cb_name;
    }
}