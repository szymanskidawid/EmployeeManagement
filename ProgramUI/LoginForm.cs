namespace ProgramUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}