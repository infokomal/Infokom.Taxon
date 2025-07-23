using AutoMapper;
using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Users.Dispatchers
{
	public class DispatcherSearchQueryHandler : IRequestHandler<DispatcherSearchQuery, List<DispatcherModel>>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public DispatcherSearchQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<DispatcherModel>> Handle(DispatcherSearchQuery request, CancellationToken cancellationToken)
		{
			var query = _context.Dispatchers.AsQueryable();
			if (!string.IsNullOrEmpty(request.Prename))
			{
				query = query.Where(d => EF.Functions.Like(d.Prename, $"{request.Prename}%"));
			}

			if (!string.IsNullOrEmpty(request.Midname))
			{
				query = query.Where(d => EF.Functions.Like(d.Midname, $"{request.Midname}%"));
			}

			if (!string.IsNullOrEmpty(request.Surname))
			{
				query = query.Where(d => EF.Functions.Like(d.Surname, $"{request.Surname}%"));
			}

			var entities = await query.ToListAsync(cancellationToken);

			return _mapper.Map<List<DispatcherModel>>(entities);
		}
	}
}
