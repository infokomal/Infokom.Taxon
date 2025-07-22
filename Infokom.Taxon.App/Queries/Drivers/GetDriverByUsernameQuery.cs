using Infokom.Taxon.App.Models;
using MediatR;

namespace Infokom.Taxon.App.Queries.Drivers
{
	public class GetDriverByUsernameQuery : IRequest<DriverModel>
	{
		public string Username { get; set; }

		public GetDriverByUsernameQuery(string username)
		{
			this.Username = username;
		}
	}
}
