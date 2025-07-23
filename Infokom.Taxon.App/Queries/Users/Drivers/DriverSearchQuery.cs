using Infokom.Taxon.App.Models.Users;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	public class DriverSearchQuery : UserSearchQuery<DriverModel>
	{
		public DriverSearchQuery() : base() { }
	}
}
