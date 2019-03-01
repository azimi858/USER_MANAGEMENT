namespace Infrastructure
{
	#region [ کلاس ابزار ها ]
	/// <summary>
	/// کلاس ابزارها
	/// </summary>
	public static class Utility
	{
		static Utility()
		{

		}

		#region [ کاربر آنلاین ]
		/// <summary>
		/// کاربر وارد شده به سامانه
		/// </summary>
		public static Models.User AuthenticatedUser { get; set; }
		#endregion [ /کاربر ]

		#region [ فرم اصلی ]
		/// <summary>
		/// فرم اصلی
		/// </summary>
		private static MyApplication.MainForm mainForm;
		
		/// <summary>
		/// فرم اصلی
		/// </summary>
		public static MyApplication.MainForm MainForm
		{
			get
			{
				if (mainForm == null)
				{
					mainForm = new MyApplication.MainForm();
				}
				return mainForm;
			}
		}
		#endregion [ /فرم اصلی ]

		#region [ فرم ثبت نام ]
		/// <summary>
		/// فرم ثبت نام
		/// </summary>
		private static MyApplication.RegisterForm registerForm;
		/// <summary>
		/// فرم ثبت نام
		/// </summary>
		public static MyApplication.RegisterForm RegisterForm
		{
			get
			{
				if (registerForm == null)
				{
					registerForm = new MyApplication.RegisterForm();
				}
				
				registerForm.ResetForm();

				return registerForm;
			}
		}
		#endregion [ /فرم ثبت نام ]

		#region [ فرم ورود ]
		/// <summary>
		/// فرم ورود
		/// </summary>
		private static MyApplication.LoginForm loginForm;
		/// <summary>
		/// فرم ورود
		/// </summary>
		public static MyApplication.LoginForm LoginForm
		{
			get
			{
				if (loginForm == null)
				{
					loginForm = new MyApplication.LoginForm();
				}

				loginForm.ResetForm();

				return loginForm;
			}
		}
		#endregion [ /فرم ورود ]

	}
	#endregion [ /کلاس ابزار ها ]
}