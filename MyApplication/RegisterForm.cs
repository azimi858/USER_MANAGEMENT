using System.Linq;

namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exitBotton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void resetBotton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
            usernameTextBox.Focus();
        }

        private void ResetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            fullnameTextBox.Text = string.Empty;
        }

        private void loginBotton_Click(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User user = databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).FirstOrDefault();

                if (user != null)
                {
                    System.Windows.Forms.MessageBox.Show("This user is currently exist");

                    usernameTextBox.Focus();

                    return;
                }

                user = new Models.User
                {
                    Username = usernameTextBox.Text,
                    Password=passwordTextBox.Text,
                    FullName = fullnameTextBox.Text,
                    
                    IsActive = true
                    
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Register Done!");

                ResetForm();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! :" + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
