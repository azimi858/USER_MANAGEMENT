namespace Models
{
	#region [ کلاس ورودی های اولیه ]
	/// <summary>
	/// ورودی های پایه
	/// </summary>
	public class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			Id = System.Guid.NewGuid();
		}

		#region [ آی دی کاربر ]
		/// <summary>
		/// آی دی کاربر
		/// </summary>
		public System.Guid Id { get; set; }
		#endregion [ /آی دی کاربر ]
	}
	#endregion [ /کلاس ورودی های اولیه ]
}