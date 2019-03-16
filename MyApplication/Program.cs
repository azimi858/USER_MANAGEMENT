using System.Linq;

namespace MyApplication
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.ToList()
				//	;

				//int userCount = users.Count;
				// **************************************************

				// **************************************************
				//int userCount =
				//	databaseContext.Users
				//	.Count();
				// **************************************************

				// **************************************************
				bool hasAnyUser =
					databaseContext.Users
					.Any();
				// **************************************************

				if (hasAnyUser == false)
				{
					Models.User adminUser = new Models.User
					{
						IsAdmin = true,
						IsActive = true,

						Username = "mAzimi",
						Password = "123456789",
						FullName = "Mr. Mehdi Azimi"
					};

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			//System.Windows.Forms.Application.Run(new LoginForm());

			#region Runing Startup Form and then Disposing!
			LoginForm loginForm = new LoginForm();

			System.Windows.Forms.Application.Run(loginForm);

			if (loginForm != null)
			{
				if (loginForm.IsDisposed == false)
				{
					loginForm.Dispose();
				}

				loginForm = null;
			}
			#endregion /Runing Startup Form and then Disposing!
			// **************************************************
		}
	}
}
