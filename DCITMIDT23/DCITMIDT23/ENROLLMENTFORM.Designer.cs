namespace DCITMIDT23
{
    partial class ENROLLMENTFORM
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
            tb_lastname = new TextBox();
            tb_middlename = new TextBox();
            tb_address = new TextBox();
            tb_age = new TextBox();
            cbo_course = new ComboBox();
            tb_firstname = new TextBox();
            groupBox1 = new GroupBox();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            lb_subjects = new ListBox();
            btn_add = new Button();
            cbo_subjects = new ComboBox();
            btn_submit = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_Cancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_lastname
            // 
            tb_lastname.Location = new Point(32, 80);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(121, 23);
            tb_lastname.TabIndex = 0;
            tb_lastname.TextChanged += tb_lastname_TextChanged;
            // 
            // tb_middlename
            // 
            tb_middlename.Location = new Point(32, 206);
            tb_middlename.Name = "tb_middlename";
            tb_middlename.Size = new Size(121, 23);
            tb_middlename.TabIndex = 0;
            // 
            // tb_address
            // 
            tb_address.Location = new Point(196, 79);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(178, 23);
            tb_address.TabIndex = 0;
            // 
            // tb_age
            // 
            tb_age.Location = new Point(196, 137);
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(178, 23);
            tb_age.TabIndex = 0;
            // 
            // cbo_course
            // 
            cbo_course.FormattingEnabled = true;
            cbo_course.Location = new Point(196, 206);
            cbo_course.Name = "cbo_course";
            cbo_course.Size = new Size(178, 23);
            cbo_course.TabIndex = 1;
            cbo_course.SelectedIndexChanged += cbo_course_SelectedIndexChanged;
            // 
            // tb_firstname
            // 
            tb_firstname.Location = new Point(32, 137);
            tb_firstname.Name = "tb_firstname";
            tb_firstname.Size = new Size(121, 23);
            tb_firstname.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_female);
            groupBox1.Controls.Add(rb_male);
            groupBox1.Location = new Point(32, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 113);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sex";
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(20, 61);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(63, 19);
            rb_female.TabIndex = 0;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(20, 29);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(51, 19);
            rb_male.TabIndex = 0;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(lb_subjects);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Controls.Add(cbo_subjects);
            groupBox2.Location = new Point(409, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 345);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Subjects";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(133, 244);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Remove";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // lb_subjects
            // 
            lb_subjects.FormattingEnabled = true;
            lb_subjects.Location = new Point(24, 68);
            lb_subjects.Name = "lb_subjects";
            lb_subjects.Size = new Size(184, 169);
            lb_subjects.TabIndex = 2;
            lb_subjects.SelectedIndexChanged += lb_subjects_SelectedIndexChanged;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(24, 244);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cbo_subjects
            // 
            cbo_subjects.FormattingEnabled = true;
            cbo_subjects.Location = new Point(24, 28);
            cbo_subjects.Name = "cbo_subjects";
            cbo_subjects.Size = new Size(184, 23);
            cbo_subjects.TabIndex = 0;
            cbo_subjects.SelectedIndexChanged += cbo_subjects_SelectedIndexChanged;
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.LimeGreen;
            btn_submit.Location = new Point(542, 376);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(93, 29);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_submit);
            panel1.Controls.Add(tb_firstname);
            panel1.Controls.Add(cbo_course);
            panel1.Controls.Add(tb_address);
            panel1.Controls.Add(tb_age);
            panel1.Controls.Add(tb_middlename);
            panel1.Controls.Add(tb_lastname);
            panel1.Location = new Point(26, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 421);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 183);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 5;
            label4.Text = "Middle Name (Optional)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 183);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 5;
            label7.Text = "Course";
            label7.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 116);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "Age";
            label6.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 116);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "First name";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 59);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Address";
            label5.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 4;
            label1.Text = "Enrollment Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cvsu_logo_removebg_preview;
            pictureBox1.Location = new Point(636, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(701, 0);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(24, 24);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "X";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // ENROLLMENTFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 485);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Cancel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ENROLLMENTFORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ENROLLMENTFORM";
            Load += ENROLLMENTFORM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_lastname;
        private TextBox tb_middlename;
        private TextBox tb_address;
        private TextBox tb_age;
        private ComboBox cbo_course;
        private TextBox tb_firstname;
        private GroupBox groupBox1;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private GroupBox groupBox2;
        private Button btn_clear;
        private ListBox lb_subjects;
        private Button btn_add;
        private ComboBox cbo_subjects;
        private Button btn_submit;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btn_Cancel;
    }
}