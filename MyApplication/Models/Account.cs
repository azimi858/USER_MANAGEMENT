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

		public string AccountNumber { get; set; }
		public string AccountName { get; set; }
		public string AccountStatus { get; set; }
		public bool AccountValue { get; set; }
		public System.DateTime AccountDate { get; set; }
		public int AccountOnlineCode { get; set; }
		public string AccountDiscription { get; set; }

	}
	#endregion [ / کلاس حساب ]
}
