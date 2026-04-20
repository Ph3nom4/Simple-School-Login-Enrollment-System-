namespace DCITMIDT23
{
    partial class LOGIN
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
            cb_showPasslogin = new CheckBox();
            txt_loginPassword = new TextBox();
            txt_loginUsername = new TextBox();
            btn_signin = new Button();
            panel1 = new Panel();
            btn_Cancel = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lb_createacc = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cb_showPasslogin
            // 
            cb_showPasslogin.AutoSize = true;
            cb_showPasslogin.Location = new Point(64, 343);
            cb_showPasslogin.Name = "cb_showPasslogin";
            cb_showPasslogin.Size = new Size(108, 19);
            cb_showPasslogin.TabIndex = 10;
            cb_showPasslogin.Text = "Show Password";
            cb_showPasslogin.UseVisualStyleBackColor = true;
            cb_showPasslogin.CheckedChanged += cb_showPasslogin_CheckedChanged;
            // 
            // txt_loginPassword
            // 
            txt_loginPassword.Location = new Point(64, 304);
            txt_loginPassword.Name = "txt_loginPassword";
            txt_loginPassword.Size = new Size(198, 23);
            txt_loginPassword.TabIndex = 8;
            txt_loginPassword.UseSystemPasswordChar = true;
            // 
            // txt_loginUsername
            // 
            txt_loginUsername.Location = new Point(64, 235);
            txt_loginUsername.Name = "txt_loginUsername";
            txt_loginUsername.Size = new Size(198, 23);
            txt_loginUsername.TabIndex = 9;
            // 
            // btn_signin
            // 
            btn_signin.BackColor = Color.LimeGreen;
            btn_signin.Location = new Point(64, 368);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(198, 34);
            btn_signin.TabIndex = 7;
            btn_signin.Text = "Sign In";
            btn_signin.UseVisualStyleBackColor = false;
            btn_signin.Click += btn_signin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(lb_createacc);
            panel1.Controls.Add(btn_Cancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_signin);
            panel1.Controls.Add(cb_showPasslogin);
            panel1.Controls.Add(txt_loginPassword);
            panel1.Controls.Add(txt_loginUsername);
            panel1.Location = new Point(418, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 525);
            panel1.TabIndex = 11;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(298, 0);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(24, 24);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "X";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 276);
            label2.Name = "label2";
            label2.Size = new Size(57, 16);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 206);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 152);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 12;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cvsu_logo_removebg_preview;
            pictureBox1.Location = new Point(122, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._79e814ee_5ef2_424c_9567_68c559b72d76;
            pictureBox3.Location = new Point(-116, -34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(617, 559);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lb_createacc
            // 
            lb_createacc.AutoSize = true;
            lb_createacc.Location = new Point(167, 416);
            lb_createacc.Name = "lb_createacc";
            lb_createacc.Size = new Size(95, 15);
            lb_createacc.TabIndex = 16;
            lb_createacc.TabStop = true;
            lb_createacc.Text = "Forgot Password";
            lb_createacc.LinkClicked += lb_createacc_LinkClicked;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 524);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox cb_showPasslogin;
        private TextBox txt_loginPassword;
        private TextBox txt_loginUsername;
        private Button btn_signin;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Cancel;
        private LinkLabel lb_createacc;
    }
}