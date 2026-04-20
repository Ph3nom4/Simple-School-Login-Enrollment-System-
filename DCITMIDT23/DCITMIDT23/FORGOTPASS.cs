using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCITMIDT23
{
    public partial class FORGOTPASS : Form
    {
        public FORGOTPASS()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

            if (txt_newPassword.Text.Length < 3)
            {
                MessageBox.Show("Please input More Characters");
                return;
            }


            CREATEACC.createAccountPassword = txt_newPassword.Text;

            LOGIN lg = new LOGIN();

            lg.Show();
            this.Hide();
        }

        private void ch_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_newPassword.UseSystemPasswordChar)
            {
                txt_newPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_newPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_newPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
