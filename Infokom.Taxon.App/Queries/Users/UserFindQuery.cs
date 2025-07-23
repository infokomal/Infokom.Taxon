using MediatR;

namespace Infokom.Taxon.App.Queries.Users
{
	public abstract class UserFindQuery<TUserItem> : IRequest<TUserItem>
	{
		public string Username { get; set; }
	}
}
