using FluentValidation;
using Infokom.Taxon.App.Models.Users;

namespace Infokom.Taxon.App.Queries.Users.Dispatchers
{
	public class DispatcherSearchQueryValidator : UserSearchQueryValidator<DispatcherSearchQuery, DispatcherModel>
	{
		public DispatcherSearchQueryValidator() : base() { }
	}
}
