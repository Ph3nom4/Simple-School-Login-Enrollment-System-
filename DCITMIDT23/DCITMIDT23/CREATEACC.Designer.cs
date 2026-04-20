namespace DCITMIDT23
{
    partial class CREATEACC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_showPass = new CheckBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            btn_signup = new Button();
            panel1 = new Panel();
            btn_Cancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cb_showPass
            // 
            cb_showPass.AutoSize = true;
            cb_showPass.Location = new Point(67, 361);
            cb_showPass.Name = "cb_showPass";
            cb_showPass.Size = new Size(108, 19);
            cb_showPass.TabIndex = 6;
            cb_showPass.Text = "Show Password";
            cb_showPass.UseVisualStyleBackColor = true;
            cb_showPass.CheckedChanged += cb_showPass_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(64, 316);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(198, 23);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(64, 248);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(198, 23);
            txt_username.TabIndex = 5;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.LimeGreen;
            btn_signup.Location = new Point(64, 396);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(198, 34);
            btn_signup.TabIndex = 3;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btn_Cancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cb_showPass);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(btn_signup);
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(415, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 525);
            panel1.TabIndex = 7;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(301, 0);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(24, 24);
            btn_Cancel.TabIndex = 10;
            btn_Cancel.Text = "X";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 287);
            label2.Name = "label2";
            label2.Size = new Size(57, 16);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 156);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 8;
            label3.Text = "Create Account";
            label3.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 218);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 8;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cvsu_logo_removebg_preview;
            pictureBox1.Location = new Point(122, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.CvSU_TIES;
            pictureBox2.Location = new Point(-172, -53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(604, 636);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._79e814ee_5ef2_424c_9567_68c559b72d76;
            pictureBox3.Location = new Point(-116, -34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(617, 559);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // CREATEACC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(739, 524);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CREATEACC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            Load += CREATEACC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox cb_showPass;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_signup;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_Cancel;
    }
}
