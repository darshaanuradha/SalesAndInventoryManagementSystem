using IMS.Presentation;
using IMS.AppLogic;

namespace IMS
{
    public partial class frmLogin : Form
    {

        private AuthService _authService = new AuthService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error");
                return;
            }

            if(true)
            //if (_authService.ValidateUser(user, pass))
            {
                MessageBox.Show("Login successful! Welcome " + user);
                frmDashboard dash = new frmDashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed");
            }



        }
    }
}
