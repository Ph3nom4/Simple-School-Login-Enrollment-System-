using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCITMIDT23
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }


        private void cb_showPasslogin_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_loginPassword.UseSystemPasswordChar)
            {
                txt_loginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_loginPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_loginUsername.Text) ||
                string.IsNullOrEmpty(txt_loginPassword.Text))
            {
                MessageBox.Show("Please Fill all required fields");
                return;
            }

            if (txt_loginUsername.Text.Length < 3 || txt_loginPassword.Text.Length < 3)
            {
                MessageBox.Show("Please input More Characters");
                return;
            }

            string createdUsername = CREATEACC.createAccountUsername;
            string createdPassword = CREATEACC.createAccountPassword;

            string loginUsername = txt_loginUsername.Text;
            string loginPassword = txt_loginPassword.Text;

            ENROLLMENTFORM ef = new ENROLLMENTFORM();


            if (createdUsername == loginUsername && createdPassword == loginPassword)
            {
                MessageBox.Show("Login Successful");

                ef.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }


        }

        private void btn_forgotPass_Click(object sender, EventArgs e)
        {
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_createacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORGOTPASS fp = new FORGOTPASS();

            fp.Show();
            this.Hide();
        }
    }
}
