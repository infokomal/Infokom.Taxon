namespace Infokom.Taxon.Core.Entities
{

	public class Client
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string PasswordHash { get; set; }
		public string FullName { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;

		
	}

}
