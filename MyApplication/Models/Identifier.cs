namespace Models
{
	public class Identifier : BaseEntity
	{
		public Identifier() : base()
		{
		}
		public string Identifire { get; set; }
		public string ExpireDate { get; set; }
		public string AddDate { get; set; }
	}
}