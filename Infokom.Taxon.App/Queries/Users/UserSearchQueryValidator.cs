using FluentValidation;
using Infokom.Taxon.App.Models;

namespace Infokom.Taxon.App.Queries.Users
{
	public class UserSearchQueryValidator<TQuery, TItem> : AbstractValidator<TQuery> where TQuery : UserSearchQuery<TItem> where TItem : UserModel
	{
		public UserSearchQueryValidator()
		{
			this.RuleFor(x => x.Prename)
				.MaximumLength(32).WithMessage("Prename must not exceed 32 characters.");
			this.RuleFor(x => x.Midname)
				.MaximumLength(32).WithMessage("Midname must not exceed 32 characters.");
			this.RuleFor(x => x.Surname)
				.MaximumLength(32).WithMessage("Surname must not exceed 32 characters.");
		}
	}
}
