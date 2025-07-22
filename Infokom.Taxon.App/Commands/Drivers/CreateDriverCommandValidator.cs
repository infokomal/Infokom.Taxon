using FluentValidation;

namespace Infokom.Taxon.App.Commands.Drivers
{
	public class CreateDriverCommandValidator : AbstractValidator<CreateDriverCommand>
	{
		public CreateDriverCommandValidator()
		{
			this.RuleFor(x => x.FullName).NotEmpty().MaximumLength(64);
			this.RuleFor(x => x.PhoneNumber).NotEmpty().MaximumLength(16);
			this.RuleFor(x => x.Username).NotEmpty().MaximumLength(64);
			this.RuleFor(x => x.PasswordHash).NotEmpty().MinimumLength(64);
		}
	}

}
