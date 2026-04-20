namespace DCITMIDT23
{
    public partial class CREATEACC : Form
    {
        public CREATEACC()
        {
            InitializeComponent();
        }

        public static string createAccountUsername = "";
        public static string createAccountPassword = "";


        private void btn_signup_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_username.Text) ||
                string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please Fill all required fields");
                return;
            }

            if (txt_username.Text.Length < 3 || txt_password.Text.Length < 3)
            {
                MessageBox.Show("Please input More Characters");
                return;
            }


            createAccountUsername = txt_username.Text;

            createAccountPassword = txt_password.Text;

            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();


        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CREATEACC_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }








}
