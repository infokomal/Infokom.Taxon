using Infokom.Taxon.App.Models;
using MediatR;

namespace Infokom.Taxon.App.Commands
{

	public abstract record UserCreateCommand : IRequest<Guid>
	{
		public string Username { get; set; }

		public string Password { get; set; }

		public string Prename { get; set; }

		public string Midname { get; set; }

		public string Surname { get; set; }

		public DateOnly? BirthDate { get; set; }

		public string BirthPlace { get; set; }

		public string Citizenship { get; set; }

		public string CitizenId { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public string Address { get; set; }
	}




}


