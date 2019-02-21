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
					$"Welcome{Infrastructure.Utility.AuthenticatedUser.Username}";
			}
			else
			{
				welcomeToolStripStatusLabel.Text =
					$"Welcome{Infrastructure.Utility.AuthenticatedUser.FullName}";
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
				updateProfileForm.Show();
			}
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
				changePasswordForm.Show();
			}
		}

		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}


	}
}
