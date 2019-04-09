using System.Linq;

namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public void InitializeMainForm()
		{
			adminToolStripMenuItem.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;

			if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
			{
				welcomeToolStripStatusLabel.Text =
					$"Welcome {Infrastructure.Utility.AuthenticatedUser.Username}";
			}
			else
			{
				welcomeToolStripStatusLabel.Text =
					$"Welcome {Infrastructure.Utility.AuthenticatedUser.FullName}";
			}
		}

		private UpdateProfileForm updateProfileForm;
		private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((updateProfileForm == null) || (updateProfileForm.IsDisposed))
			{
				updateProfileForm = new UpdateProfileForm
				{
					MdiParent = this
				};
			}
			updateProfileForm.Show();
		}

		private ChangePasswordForm changePasswordForm;
		private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (changePasswordForm == null || changePasswordForm.IsDisposed)
			{
				changePasswordForm = new ChangePasswordForm
				{
					MdiParent = this
				};
			}
			changePasswordForm.Show();
		}

		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.MainForm.Hide();
			Infrastructure.Utility.AuthenticatedUser = null;
			Infrastructure.Utility.LoginForm.Show();
		}

		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult result =
				System.Windows.Forms.MessageBox.Show
					(text: "آیا به خروج از برنامه اطمینان دارید؟",
					caption: "سوال",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		private Admin.UsersListForm usersListForm;

		private void UsersListToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((usersListForm == null) || (usersListForm.IsDisposed))
			{
				usersListForm = new Admin.UsersListForm
				{
					MdiParent = this
				};

				usersListForm.Show();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.Account account =
					databaseContext.Accounts
					.Where(current => string.Compare(current.AccountNumber, accountNumberTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (account == null)
				{
					account = new Models.Account
					{
						AccountNumber = accountNumberTextBox.Text,
						AccountName = "درامدی",
						AccountStatus = "",
						AccountValue = true,
						AccountOnlineCode = 22,
						AccountDiscription = "",
						AccountDate = System.DateTime.Now
					};

					databaseContext.Accounts.Add(account);

					databaseContext.SaveChanges();
				}


				Models.Identifier identifier =
					databaseContext.Idents
					.Where(current => string.Compare(current.Identifire, identifireTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (identifier != null)
				{
					System.Windows.Forms.MessageBox.Show
						("This Identifire is already exist!");

					identifireTextBox.Focus();

					return;
				}

				identifier = new Models.Identifier
				{
					Identifire = identifireTextBox.Text,
					IdentifireExpireDate = System.DateTime.Now,
					IdentifireAddDate = System.DateTime.Today,
					UserId = Infrastructure.Utility.AuthenticatedUser,
					IdentifireStatus = "فعال",
					IdentifireType = "فارغ از مبلغ"
				};
                databaseContext.Entry(Infrastructure.Utility.AuthenticatedUser).State = System.Data.Entity.EntityState.Unchanged;
				databaseContext.Idents.Add(identifier);                
				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Identifire Aded ...");

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
	}
}
