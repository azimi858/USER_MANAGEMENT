namespace Models
{
	#region [ کلاس شناسه ]

	/// <summary>
	/// کلاس مشخصات کاربر
	/// </summary>
	public class Identifier : BaseEntity
	{
		public Identifier() : base()
		{
		}
		public string Identifire { get; set; }
		public string IdentifireType { get; set; }
		public string IdentifireStatus { get; set; }
		public System.DateTime IdentifireAddDate { get; set; }
		public System.DateTime IdentifireExpireDate { get; set; }
		public System.Guid UserId { get; set; }
		public System.Guid AccountId { get; set; }
	}
	#endregion [ /کلاس شناسه ]
}