using System.Linq;

namespace MyApplication
{
	public partial class UpdateProfileForm : Infrastructure.BaseForm
	{
		public UpdateProfileForm()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.User currentUser = databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				currentUser.FullName = fullNameTextBox.Text;
				currentUser.Description = descriptionTextBox.Text;

				databaseContext.SaveChanges();

				Infrastructure.Utility.AuthenticatedUser = currentUser;

				MainForm mainForm = this.MdiParent as MainForm;
				if (mainForm!=null)
				{
					mainForm.InitializeMainForm();
				}

				System.Windows.Forms.MessageBox.Show("Your profile Updated ...");
				
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

		private void UpdateProfileForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.User currentUser = databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				 fullNameTextBox.Text = currentUser.FullName;
				 descriptionTextBox.Text = currentUser.Description;

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
			Hide();
		}
	}
}
