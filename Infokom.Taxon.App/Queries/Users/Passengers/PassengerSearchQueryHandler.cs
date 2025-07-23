using AutoMapper;
using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Users.Passengers
{
	public class PassengerSearchQueryHandler : IRequestHandler<PassengerSearchQuery, List<PassengerModel>>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public PassengerSearchQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<PassengerModel>> Handle(PassengerSearchQuery request, CancellationToken cancellationToken)
		{
			var query = _context.Drivers.AsQueryable();
			if (!string.IsNullOrEmpty(request.Prename))
				query = query.Where(d => EF.Functions.Like(d.Prename, $"{request.Prename}%"));

			if (!string.IsNullOrEmpty(request.Midname))
				query = query.Where(d => EF.Functions.Like(d.Midname, $"{request.Midname}%"));

			if (!string.IsNullOrEmpty(request.Surname))
				query = query.Where(d => EF.Functions.Like(d.Surname, $"{request.Surname}%"));

			var entities = await query.ToListAsync(cancellationToken);

			return _mapper.Map<List<PassengerModel>>(entities);
		}
	}
}
