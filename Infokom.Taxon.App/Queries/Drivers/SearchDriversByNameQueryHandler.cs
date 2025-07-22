using AutoMapper;
using Infokom.Taxon.App.Mappers;
using Infokom.Taxon.App.Models;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Drivers
{
	public class SearchDriversByNameQueryHandler : IRequestHandler<SearchDriversByNameQuery, List<DriverModel>>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public SearchDriversByNameQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<DriverModel>> Handle(SearchDriversByNameQuery request, CancellationToken cancellationToken)
		{
			var query = _context.Drivers.AsQueryable();

			if (!string.IsNullOrWhiteSpace(request.Name))
			{
				query = query.Where(d => d.FullName.Contains(request.Name));
			}

			var drivers = await query.ToListAsync(cancellationToken);
			return _mapper.Map<List<DriverModel>>(drivers); 
		}
	}
}
