using Infokom.Taxon.App.Models.Users;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users.Passengers
{
	public class PassengerFindQuery : UserFindQuery<PassengerModel>
	{
		public PassengerFindQuery() : base() { }
	}
}
