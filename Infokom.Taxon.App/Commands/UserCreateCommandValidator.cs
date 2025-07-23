using FluentValidation;

namespace Infokom.Taxon.App.Commands
{
	public abstract class UserCreateCommandValidator : AbstractValidator<UserCreateCommand>
	{
		protected UserCreateCommandValidator()
		{
			this.RuleFor(x => x.Username).NotEmpty().MaximumLength(64);
			this.RuleFor(x => x.Password).NotEmpty().MinimumLength(64);
			this.RuleFor(x => x.Prename).MaximumLength(32);
			this.RuleFor(x => x.Midname).MaximumLength(32);
			this.RuleFor(x => x.Surname).MaximumLength(32);
			this.RuleFor(x => x.BirthPlace).MaximumLength(64);
			this.RuleFor(x => x.Phone).MaximumLength(16);
			this.RuleFor(x => x.Email).EmailAddress().MaximumLength(320);
			this.RuleFor(x => x.Address).MaximumLength(256);
		}
	}




}


