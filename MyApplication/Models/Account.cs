namespace Models
{
	#region [ کلاس حساب ]

	/// <summary>
	/// کلاس مشخصات حساب
	/// </summary>
	public class Account : BaseEntity
	{
		public Account() : base()
		{
		}

		#region [ شماره حساب ]

		#region [ محدودیتهای شماره حساب ]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength(30)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		#endregion [ /محدودیتهای شماره حساب ]

		public string AccountNumber { get; set; }
		#endregion [ /شماره حساب ]

		#region [ نام حساب]
		public string AccountName { get; set; }
		#endregion [ /نام حساب ]

		#region [ عنوان حساب ]
		public string AccountStatus { get; set; }
		#endregion [ /عنوان حساب ]

		#region [ مقدار حساب ]
		public bool AccountValue { get; set; }
		#endregion [ /مقدار حساب ]

		#region [ تاریخ حساب ]
		public System.DateTime AccountDate { get; set; }
		#endregion [ /تاریخ حساب ]

		#region [ کد آنلاین حساب ]
		public int AccountOnlineCode { get; set; }
		#endregion [ /کد آنلاین حساب ]

		#region [ توضیحات حساب ]
		public string AccountDiscription { get; set; }
		#endregion [ /توضیحات حساب ]

	}
	#endregion [ / کلاس حساب ]
}