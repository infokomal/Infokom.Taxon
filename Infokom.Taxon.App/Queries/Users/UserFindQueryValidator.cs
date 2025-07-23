using FluentValidation;

namespace Infokom.Taxon.App.Queries.Users
{
	public abstract class UserFindQueryValidator<TUserItem> : AbstractValidator<UserFindQuery<TUserItem>>
	{
		protected UserFindQueryValidator()
		{
			this.RuleFor(x => x.Username)
				.NotEmpty().WithMessage("Username is required.")
				.MaximumLength(100).WithMessage("Username must not exceed 100 characters.");
		}
	}
}
