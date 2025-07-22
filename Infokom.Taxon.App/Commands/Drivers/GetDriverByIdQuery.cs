using MediatR;
using Infokom.Taxon.App.Models;

namespace Infokom.Taxon.App.Commands.Drivers
{
	public class GetDriverByIdQuery : IRequest<DriverModel>
	{
		public Guid Id { get; set; }

		public GetDriverByIdQuery(Guid id)
		{
			Id = id;
		}
	}
}
