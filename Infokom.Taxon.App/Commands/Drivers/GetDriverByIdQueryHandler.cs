using AutoMapper;
using Infokom.Taxon.App.Mappers;
using Infokom.Taxon.App.Models;
using Infokom.Taxon.Data;
using MediatR;

namespace Infokom.Taxon.App.Commands.Drivers
{
	public class GetDriverByIdQueryHandler : IRequestHandler<GetDriverByIdQuery, DriverModel>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public GetDriverByIdQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<DriverModel> Handle(GetDriverByIdQuery request, CancellationToken cancellationToken)
		{
			var driver = await _context.Drivers.FindAsync(request.Id, cancellationToken);

			return driver == null ? null : _mapper.Map<DriverModel>(driver);
		}
	}

}
