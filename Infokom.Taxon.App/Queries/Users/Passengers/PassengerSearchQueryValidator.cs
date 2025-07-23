using FluentValidation;
using Infokom.Taxon.App.Models.Users;

namespace Infokom.Taxon.App.Queries.Users.Passengers
{
	public class PassengerSearchQueryValidator : UserSearchQueryValidator<PassengerSearchQuery, PassengerModel>
	{
		public PassengerSearchQueryValidator() : base() { }
	}
}
