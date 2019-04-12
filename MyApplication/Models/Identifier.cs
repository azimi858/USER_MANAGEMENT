namespace Models
{
	#region [ کلاس شناسه ]

	/// <summary>
	/// کلاس مشخصات شناسه
	/// </summary>
	public class Identifier : BaseEntity
	{
		public Identifier() : base()
		{
		}

		#region [ شناسه ]

		#region [ محدودیتهای شناسه ]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30, MinimumLength = 30)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		#endregion [ /محدودیتهای شناسه ]

		/// <summary>
		/// شناسه
		/// </summary>
		public string Identifire { get; set; }

		#endregion [ /شناسه ]

		#region [ نوع شناسه ]
		/// <summary>
		/// نوع شناسه
		/// </summary>
		public string IdentifireType { get; set; }
		#endregion [ /نوع شناسه ]

		#region [ عنوان شناسه ]
		/// <summary>
		/// عنوان شناسه
		/// </summary>
		public string IdentifireStatus { get; set; }
		#endregion [ /عنوان شناسه ]

		#region [ تاریخ کارسازی شناسه ]
		/// <summary>
		/// تاریخ کارسازی شناسه
		/// </summary>
		public System.DateTime IdentifireCreateDate { get; set; }
		#endregion [ /تاریخ کارسازی شناسه ]

		#region [ زمان کارسازی شناسه ]
		/// <summary>
		/// زمان کارسازی شناسه
		/// </summary>
		public System.DateTime IdentifireCreateTime { get; set; }
		#endregion [ /زمان کارسازی شناسه ]

		#region [ تاریخ انقضای شناسه ]

		/// <summary>
		/// تاریخ انقضای شناسه
		/// </summary>
		public System.DateTime IdentifireExpireDate { get; set; }

		#endregion [ /تاریخ انقضای شناسه ]

		#region [ فعال/غیرفعال ]

		/// <summary>
		/// فعال/غیرفعال
		/// </summary>
		public bool IdentifireActive { get; set; }

		#endregion [ /فعال/غیرفعال ]

		#region [ کاربر فعال ]
		/// <summary>
		/// کاربر فعال
		/// </summary>
		//[System.ComponentModel.DataAnnotations.Schema.ForeignKey("User")]
		public Models.User UserId { get; set; }

		#endregion [ /کاربر فعال ]

		#region [ حساب فعال ]
		/// <summary>
		/// حساب فعال
		/// </summary>
		public Models.Account AccountId { get; set; }

		#endregion [ /حساب فعال ]
	}
	#endregion [ /کلاس شناسه ]
}