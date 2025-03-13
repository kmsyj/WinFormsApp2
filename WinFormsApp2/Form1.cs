namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string mockUsername = "Kimsy";
        private string mockPassword = "777";
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtusername.Text;
            string enteredPassword = txtpassword.Text;

            if (enteredUsername == mockUsername && enteredPassword == mockPassword)
            {
                
                Form2 studentForm = new Form2();
                studentForm.ShowDialog();
                this.Close();
            }
            loginAttempts++;


            if (string.IsNullOrEmpty(enteredUsername) && string.IsNullOrEmpty(enteredPassword))
            {
                errorProvider1.SetError(txtusername, "Username is required!");
                errorProvider2.SetError(txtpassword, "Password is required!");
            }
            else if (string.IsNullOrEmpty(enteredUsername))
            {
                errorProvider1.SetError(txtusername, "Username is required!");
                errorProvider2.SetError(txtpassword, "");
            }
            else if (string.IsNullOrEmpty(enteredPassword))
            {
                errorProvider1.SetError(txtpassword, "Password is required!");
                errorProvider2.SetError(txtusername, "");
            }
            else if (enteredUsername != mockUsername && enteredPassword != mockPassword)
            {
                errorProvider1.SetError(txtusername, "Incorrect username.");
                errorProvider2.SetError(txtpassword, "Incorrect password.");
            }
            else if (enteredUsername != mockUsername)
            {
                errorProvider1.SetError(txtusername, "Incorrect username.");
                errorProvider2.SetError(txtpassword, "");
            }
            else if (enteredPassword != mockPassword)
            {
                errorProvider2.SetError(txtpassword, "Incorrect password.");
                errorProvider1.SetError(txtusername, "");
            }


            if (loginAttempts >= maxLoginAttempts)
            {
                MessageBox.Show("Maximum attempts reached! Reset your password here:\nhttps://resetpassword.com",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnlogin.Enabled = false;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
