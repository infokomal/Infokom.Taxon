using FluentValidation;
using Infokom.Taxon.App.Models.Users;
using MediatR;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	public class  DriverSearchQueryValidator : UserSearchQueryValidator<DriverSearchQuery, DriverModel>
	{
		public DriverSearchQueryValidator() : base() { }

	}
}
