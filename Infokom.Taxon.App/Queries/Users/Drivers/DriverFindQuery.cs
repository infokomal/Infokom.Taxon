using Infokom.Taxon.App.Models.Users;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	

	public class DriverFindQuery : UserFindQuery<DriverModel>
	{
		public DriverFindQuery() : base() { }
	}
}
