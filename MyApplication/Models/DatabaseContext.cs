namespace Models
{
	#region [ کلاس پایگاه داده ]
	/// <summary>
	/// پایگاه داده
	/// </summary>
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		#region [ ایجاد پایگاه داده ]
		/// <summary>
		/// ایجاد پایگاه داده
		/// </summary>
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}
		#endregion [ /ایجاد پایگاه داده ]

		public DatabaseContext() : base()
		{
		}

		#region [ کاربر ]
		/// <summary>
		/// کاربر
		/// </summary>
		public System.Data.Entity.DbSet<User> Users { get; set; }
		#endregion [ /کاربر ]

		#region [ شناسه ]
		/// <summary>
		/// کاربر
		/// </summary>
		public System.Data.Entity.DbSet<Identifier> Idents { get; set; }
		#endregion [ /شناسه ]
	}
	#endregion [ /کلاس پایگاه داده ]
}