﻿using System.Linq;

namespace MyApplication
{
	public partial class ChangePasswordForm : Infrastructure.BaseForm
	{
		public ChangePasswordForm()
		{
			InitializeComponent();
		}

		private void ChangePasswordForm_Load(object sender, System.EventArgs e)
		{

		}

		private void changePasswordButton_Click(object sender, System.EventArgs e)
		{
			string errorMessages = string.Empty;

			if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
			{
				errorMessages =
					"Old password is required...";
			}
			if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
			{
				if (errorMessages != string.Empty)
				{
					errorMessages += System.Environment.NewLine;
				}

				errorMessages +=
					"New password is required...";
			}
			else
			{
				if (newPasswordTextBox.Text.Length < 8)
				{
					if (errorMessages != string.Empty)
					{
						errorMessages += System.Environment.NewLine;
					}

					errorMessages +=
						"The new password length should be 8 characters or greater...";
				}
			}

			if (string.IsNullOrWhiteSpace(confirmNewPasswordTextBox.Text))
			{
				if (errorMessages != string.Empty)
				{
					errorMessages += System.Environment.NewLine;
				}

				errorMessages +=
					"Confirm new password is required...";
			}
			else
			{
				if (string.Compare(confirmNewPasswordTextBox.Text, newPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					if (errorMessages != string.Empty)
					{
						errorMessages += System.Environment.NewLine;
					}

					errorMessages +=
						"The confirm new password is not equal to new password...";
				}
			}

			if (errorMessages != string.Empty)
			{
				System.Windows.Forms.MessageBox.Show(errorMessages);

				oldPasswordTextBox.Focus();

				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.User currentUser = databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id).FirstOrDefault();

				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				if (string.Compare(currentUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					System.Windows.Forms.MessageBox.Show("Old password is not correct...");

					oldPasswordTextBox.Focus();

					return;
				}

				currentUser.Password = newPasswordTextBox.Text;

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Your password changed successfully...");
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

		private void closeButton_Click(object sender, System.EventArgs e)
		{
			Hide();
		}
	}
}
