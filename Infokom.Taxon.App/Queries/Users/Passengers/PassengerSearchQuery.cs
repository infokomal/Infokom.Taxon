using Infokom.Taxon.App.Models.Users;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users.Passengers
{
	public class PassengerSearchQuery : UserSearchQuery<PassengerModel>
	{
		public PassengerSearchQuery() : base() { }
	}
}
