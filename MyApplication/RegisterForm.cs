using System.Linq;

namespace MyApplication
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
		}

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
				(string.IsNullOrWhiteSpace(passwordTextBox.Text)))
			{
				usernameTextBox.Text =
					usernameTextBox.Text.Replace(" ", string.Empty);

				passwordTextBox.Text =
					passwordTextBox.Text.Replace(" ", string.Empty);

				System.Windows.Forms.MessageBox.Show("Username & Password is required ...");

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

			string errorMessages = string.Empty;

			if (usernameTextBox.Text.Length < 6)
			{
				errorMessages = "Username length should be at least 6 characters!";
			}

			if (passwordTextBox.Text.Length < 8)
			{
				if (errorMessages != string.Empty)
				{
					errorMessages += System.Environment.NewLine;
				}
				errorMessages += "Password length should be at least 8 characters!";
			}

			if (errorMessages != string.Empty)
			{
				System.Windows.Forms.MessageBox.Show(errorMessages);

				return;
			}


			// **************************************************

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.User user = 
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if(user != null)
				{
					System.Windows.Forms.MessageBox.Show
						("This username is already exist! Please choose another one...");

					usernameTextBox.Focus();

					return;
				}

				user = new Models.User
				{
					Username = usernameTextBox.Text,
					Password=passwordTextBox.Text,
					FullName = fullnameTextBox.Text,

					IsActive=true
				};

				databaseContext.Users.Add(user);

				databaseContext.SaveChanges();

				Hide();

				Infrastructure.Utility.LoginForm.Show();

				System.Windows.Forms.MessageBox.Show("registration Done ...");

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
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

		private void ResetBotton_Click(object sender, System.EventArgs e)
		{
			ResetForm();
		}

		public void ResetForm()
		{
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;
			fullnameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void LoginBotton_Click(object sender, System.EventArgs e)
		{
			Hide();
			Infrastructure.Utility.LoginForm.Show();
		}

		private void ExitBotton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void RegisterForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
