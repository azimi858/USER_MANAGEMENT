using System.Linq;

namespace MyApplication.Admin
{
	public partial class UsersListForm : Infrastructure.BaseForm
	{
		public UsersListForm()
		{
			InitializeComponent();
		}
		private void UsersListForm_Load(object sender, System.EventArgs e)
		{

		}

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			Search();
		}

		private void Search()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				fullNameTextBox.Text = fullNameTextBox.Text.Trim();

				while (fullNameTextBox.Text.Contains("  "))
				{
					fullNameTextBox.Text.Replace("  ", " ");
				}

				System.Collections.Generic.List<Models.User> users = null;

				if (fullNameTextBox.Text == string.Empty)
				{
					users =
						databaseContext.Users
						.OrderBy(current => current.FullName)
						.ToList();
				}
				else
				{
					users =
						databaseContext.Users
						.Where(current => current.FullName.Contains(fullNameTextBox.Text))
						.OrderBy(current => current.FullName)
						.ToList();
				}

				usersListBox.ValueMember = "Id";
				usersListBox.DisplayMember = "DisplayName";
				usersListBox.DataSource = users;
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

		private void UsersListBox_DoubleClick(object sender, System.EventArgs e)
		{
			Models.User selectedUser =
				usersListBox.SelectedItem as Models.User;

			if (selectedUser != null)
			{
				UpdateUserForm updateUserForm = new UpdateUserForm
				{
					SelectedUser = selectedUser
				};

				updateUserForm.ShowDialog();

				Search();
			}


		}

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
