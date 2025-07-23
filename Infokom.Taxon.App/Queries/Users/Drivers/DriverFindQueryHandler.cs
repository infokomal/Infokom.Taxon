using AutoMapper;
using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	public class DriverFindQueryHandler : IRequestHandler<DriverFindQuery, DriverModel>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public DriverFindQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<DriverModel> Handle(DriverFindQuery request, CancellationToken cancellationToken)
		{
			var entity = await _context.Drivers.FirstOrDefaultAsync(d => d.Username == request.Username, cancellationToken);
			
			var model = entity is null ? null : _mapper.Map<DriverModel>(entity);

			return model;
		}
	}	
}
