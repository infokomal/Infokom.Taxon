using Infokom.Taxon.App.Mappers;
using Infokom.Taxon.App.Models.Users;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	public class DispatcherFindQuery : UserFindQuery<DispatcherModel>
	{
		public DispatcherFindQuery() : base() { }
	}
}
