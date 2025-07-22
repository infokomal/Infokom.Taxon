using MediatR;

namespace Infokom.Taxon.App.Commands.Drivers
{
	public class CreateDriverCommand : IRequest<Guid>
	{
		public string Username { get; set; }
		public string PasswordHash { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
		
	}
}


