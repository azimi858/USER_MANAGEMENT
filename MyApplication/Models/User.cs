namespace Models
{
	#region [ کلاس کاربر ]

	/// <summary>
	/// کلاس مشخصات کاربر
	/// </summary>
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		#region [ وضعیت فعال ]
		/// <summary>
		/// وضعیت فعال
		/// </summary>
		public bool IsActive { get; set; }

		#endregion [ /وضعیت فعال ]

		#region [ وضعیت ادمین ]

		/// <summary>
		/// وضعیت ادمین
		/// </summary>
		public bool IsAdmin { get; set; }

		#endregion [ /وضعیت ادمین ]

		#region [ نام کاربری ]

		#region [ محدودیتهای نام کاربری ]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength : 20, MinimumLength = 6)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		#endregion [ /محدودیتهای نام کاربری ]

		/// <summary>
		/// نان کاربری
		/// </summary>
		public string Username { get; set; }

		#endregion [ /نام کاربری ]

		#region [ رمز عبور ]

		#region [ محدودیتهای رمز عبور ]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40, MinimumLength = 8)]

		#endregion [ /محدودیتهای رمز عبور ]

		/// <summary>
		/// رمز عبور
		/// </summary>
		public string Password { get; set; }

		#endregion [ /رمز عبور ]

		#region [ نام و نام خانوادگی ]

		#region [ محدودیتها نام و نام خانوادگی ]
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		#endregion [ /محدودیتها نام و نام خانوادگی ]

		/// <summary>
		/// نام و نام خانوادگی
		/// </summary>
		public string FullName { get; set; }

		#endregion [ /نام و نام خانوادگی ]

		#region [ توضیحات ]

		/// <summary>
		/// توضیحات
		/// </summary>
		public string Description { get; set; }

		#endregion [ /توضیحات ]

		#region [ نام نمایشی ]

		/// <summary>
		/// نام نمایشی
		/// </summary>
		public string DisplayName
		{
			get
			{
				string result = string.Empty;

				if (string.IsNullOrWhiteSpace(FullName) == false)
				{
					result = FullName;
				}

				if (result != string.Empty)
				{
					result += " - ";
				}

				if (IsActive)
				{
					result += $" [Enable]";
				}
				else
				{
					result += $" [Disable]";
				}

				if (IsAdmin)
				{
					result += $" [Admin]";
				}
				else
				{
					result += $" [User]";
				}

				return result;
			}
		}

		#endregion [ /نام نمایشی ]

	}
	#endregion [ /کلاس کاربر  ]
}