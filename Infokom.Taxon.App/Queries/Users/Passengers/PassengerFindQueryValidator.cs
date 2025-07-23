using FluentValidation;
using Infokom.Taxon.App.Models.Users;

namespace Infokom.Taxon.App.Queries.Users.Passengers
{
	public class PassengerFindQueryValidator : UserFindQueryValidator<PassengerModel>
	{
		public PassengerFindQueryValidator() : base() { }
	}
}
