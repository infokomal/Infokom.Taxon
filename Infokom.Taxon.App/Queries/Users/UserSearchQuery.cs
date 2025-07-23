using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.App.Queries.Users.Drivers;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users
{
	public class UserSearchQuery<TUserItem> : IRequest<List<TUserItem>>
	{
		public string Prename { get; set; }
		public string Midname { get; set; }
		public string Surname { get; set; }
	}
}
