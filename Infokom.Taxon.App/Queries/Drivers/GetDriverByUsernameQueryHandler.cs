using AutoMapper;
using Infokom.Taxon.App.Mappers;
using Infokom.Taxon.App.Models;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Drivers
{
	public class GetDriverByUsernameQueryHandler : IRequestHandler<GetDriverByUsernameQuery, DriverModel>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;


		public GetDriverByUsernameQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<DriverModel> Handle(GetDriverByUsernameQuery request, CancellationToken cancellationToken)
		{
			var driver = await _context.Drivers
			    .FirstOrDefaultAsync(d => d.Username == request.Username, cancellationToken);

			return _mapper.Map<DriverModel>(driver); // entity → model
		}
	}
}
