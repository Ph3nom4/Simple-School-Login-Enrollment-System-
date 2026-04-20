namespace DCITMIDT23
{
    partial class FORGOTPASS
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
            txt_newPassword = new TextBox();
            btn_signup = new Button();
            ch_showPass = new CheckBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            btn_Cancel = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(61, 246);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(198, 23);
            txt_newPassword.TabIndex = 6;
            txt_newPassword.UseSystemPasswordChar = true;
            txt_newPassword.TextChanged += txt_newPassword_TextChanged;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.LimeGreen;
            btn_signup.ForeColor = SystemColors.ControlText;
            btn_signup.Location = new Point(100, 367);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(113, 34);
            btn_signup.TabIndex = 5;
            btn_signup.Text = "Change Password";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // ch_showPass
            // 
            ch_showPass.AutoSize = true;
            ch_showPass.Location = new Point(61, 293);
            ch_showPass.Name = "ch_showPass";
            ch_showPass.Size = new Size(108, 19);
            ch_showPass.TabIndex = 7;
            ch_showPass.Text = "Show Password";
            ch_showPass.UseVisualStyleBackColor = true;
            ch_showPass.CheckedChanged += ch_showPass_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._79e814ee_5ef2_424c_9567_68c559b72d76;
            pictureBox3.Location = new Point(-116, -34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(617, 559);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btn_Cancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ch_showPass);
            panel1.Controls.Add(txt_newPassword);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_signup);
            panel1.Location = new Point(415, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 525);
            panel1.TabIndex = 11;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(301, 0);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(24, 24);
            btn_Cancel.TabIndex = 11;
            btn_Cancel.Text = "X";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 218);
            label2.Name = "label2";
            label2.Size = new Size(115, 16);
            label2.TabIndex = 8;
            label2.Text = "Input New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 151);
            label3.Name = "label3";
            label3.Size = new Size(167, 30);
            label3.TabIndex = 8;
            label3.Text = "Change Pasword";
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
            // FORGOTPASS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 524);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FORGOTPASS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FORGOTPASS";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_newPassword;
        private Button btn_signup;
        private CheckBox ch_showPass;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_Cancel;
    }
}