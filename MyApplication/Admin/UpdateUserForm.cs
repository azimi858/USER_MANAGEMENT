using System.Linq;

namespace MyApplication.Admin
{
	public partial class UpdateUserForm : Infrastructure.BaseForm
	{
		public UpdateUserForm()
		{
			InitializeComponent();
		}

		public Models.User SelectedUser { get; set; }

		private void UpdateUserForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User foundedUser =
					databaseContext.Users
					.Where(current => current.Id == SelectedUser.Id)
					.FirstOrDefault();

				if(foundedUser == null)
				{
					System.Windows.Forms.MessageBox.Show("There is no such a user anymore!");

					Close();
				}

				isActiveCheckBox.Checked = foundedUser.IsActive;
				isAdminCheckBox.Checked = foundedUser.IsAdmin;

				fullNameTextBox.Text = foundedUser.FullName;
				descriptionTextBox.Text = foundedUser.Description;


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

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void saveAndCloseButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User foundedUser =
					databaseContext.Users
					.Where(current => current.Id == SelectedUser.Id)
					.FirstOrDefault();

				foundedUser.IsActive = isActiveCheckBox.Checked;
				foundedUser.IsAdmin = isAdminCheckBox.Checked;

				foundedUser.FullName = fullNameTextBox.Text;
				foundedUser.Description = descriptionTextBox.Text;

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Your Changes saved...");

				Close();

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
				Close();
			}
			finally
			{
				if(databaseContext!=null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
