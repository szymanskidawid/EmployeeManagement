using ProgramLibrary;

namespace ProgramUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Attempts to log in using values provided by the user.
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(LoginFormValidation())
            {
                MainForm mf = new MainForm();
                mf.Show();

                //Login form is hidden in memory, closing it would close the entire application.
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Login or password incorrect, please try again.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        // Validation method that returns if user input is valid.
        private bool LoginFormValidation()
        {
            bool isValid = new();

            string login = usernameValue.Text;
            string password = passwordValue.Text;

            return isValid = SqlConnector.LoginSystem(login, password);
        }
    }
}