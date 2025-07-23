using FluentValidation;
using Infokom.Taxon.App.Models.Users;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	public class DriverFindQueryValidator : UserFindQueryValidator<DriverFindQuery>
	{
		public DriverFindQueryValidator() : base() { }
	}
}
