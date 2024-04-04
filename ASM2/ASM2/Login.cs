namespace ASM2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password is not empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username.Equals("doviet196") && password.Equals("12345"))
            {
                // dang nhap thanh cong
                this.Hide(); // an form login
                // mo form Water Bill
                WaterBill waterBill = new WaterBill();
                waterBill.Show();
            }
            else
            {
                MessageBox.Show("Account invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
