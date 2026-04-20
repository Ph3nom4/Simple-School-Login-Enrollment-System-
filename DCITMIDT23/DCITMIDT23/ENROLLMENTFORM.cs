using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCITMIDT23
{
    public partial class ENROLLMENTFORM : Form
    {
        public ENROLLMENTFORM()
        {
            InitializeComponent();
        }


        string lname, fname, mname, address, age, course, sex;

        string[] arrofSubjects = { };

        string[] arrOfCourseForDisplay = { "BSIT", "BSCS", "BSCPE", "BSHM", "BSHRM" };


        //Cbo Subs

        string[] cssubs = { "Programming", "Networking", "Database", "Operating Systems", "Object-Oriented Programming" };
        string[] cpesubs = { "Calculus 1", "Calculus 2", "Programming", "Science Tech", "Data Structures" };
        string[] itsubs = { "Computer Programming 1", "Computer Programming 2", "Intro to Computers", "Discrete Math", "Database" };
        string[] hmsubs = { "FITT", "NSTP", "Hospitality, Purposive Communication", "Food Service Operations", "Management in Tourism" };
        string[] hrmsubs = { "GNED14", "GNED09", "MMW", "Philosophy", "Huamn Sociology" };


        private void ENROLLMENTFORM_Load(object sender, EventArgs e)
        {
            foreach (string course in arrOfCourseForDisplay)
            {
                cbo_course.Items.Add(course);
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbo_subjects.SelectedItem != null)
            {
                lb_subjects.Items.Add(cbo_subjects.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a subject first.");
            }
        }

        private void tb_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_firstname.Text) ||
                string.IsNullOrWhiteSpace(tb_lastname.Text) ||
                string.IsNullOrWhiteSpace(tb_address.Text) ||
                string.IsNullOrWhiteSpace(tb_age.Text) ||
                    !rb_male.Checked && !rb_female.Checked)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }



            lname = tb_lastname.Text;
            fname = tb_firstname.Text;
            mname = tb_middlename.Text;
            address = tb_address.Text;
            age = tb_age.Text;

            if (lb_subjects.Items.Count == 0)
            {
                MessageBox.Show("No subjects selected");
                return;

            }

            string course = cbo_course.SelectedItem.ToString();

            string selectedsub = "";
            foreach (var item in lb_subjects.Items)
            {
                selectedsub += item.ToString() + "\n";
            }

            if (rb_male.Checked)
            {
                sex = rb_male.Text;
            }
            else
            {
                sex = rb_female.Text;
            }

            MessageBox.Show("Enrollment Succesfull");

            MessageBox.Show(
                  $"Student Info\n\n" +
                  $"Name: {fname} {mname} {lname}\n" +
                  $"Address: {address}\n" +
                  $"Age: {age}\n" +
                  $"Sex: {sex}\n" +
                  $"Course: {course}\n\n" +
                  $"Subjects: \n{selectedsub}\n",
                  "Enrollment Form"

              );

            this.Hide();


        }

        private void cbo_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_subjects.Items.Clear();

            if (cbo_course.Text == "BSCS")
            {
                foreach (string subjects in cssubs)
                {
                    cbo_subjects.Items.Add(subjects);
                }
            }
            else if (cbo_course.Text == "BSCPE")
            {
                foreach (string subjects in cpesubs)
                {
                    cbo_subjects.Items.Add(subjects);
                }

            }
            else if (cbo_course.Text == "BSIT")
            {
                foreach (string subjects in cpesubs)
                {
                    cbo_subjects.Items.Add(subjects);
                }
            }

            else if (cbo_course.Text == "BSHM")
            {
                foreach (string subjects in hmsubs)
                {
                    cbo_subjects.Items.Add(subjects);
                }
            }


            else if (cbo_course.Text == "BSHRM")
            {
                foreach (string subjects in hrmsubs)
                {
                    cbo_subjects.Items.Add(subjects);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (lb_subjects.SelectedIndex != -1)
            {
                lb_subjects.Items.RemoveAt(lb_subjects.SelectedIndex);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbo_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}
