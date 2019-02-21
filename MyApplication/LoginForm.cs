using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                System.Windows.Forms.MessageBox.Show("Username and Password is required!");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User foundedUser = databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct");

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct");

                    usernameTextBox.Focus();

                    return;
                }

                if(foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox.Show("You can not login , please contact support team.");

                    return;
                }
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //System.Windows.Forms.MessageBox.Show("Welcome...");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error" + ex.Message);
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

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
            usernameTextBox.Focus();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            Hide();
            registerForm.Show();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ResetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }
    }
}
