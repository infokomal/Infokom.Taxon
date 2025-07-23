using AutoMapper;
using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Users.Drivers
{
	public class DispatcherFindQueryHandler : IRequestHandler<DispatcherFindQuery, DispatcherModel>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public DispatcherFindQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<DispatcherModel> Handle(DispatcherFindQuery request, CancellationToken cancellationToken)
		{
			var entity = await _context.Dispatchers.FirstOrDefaultAsync(d => d.Username == request.Username, cancellationToken);

			var model = entity is null ? null : _mapper.Map<DispatcherModel>(entity);

			return model;
		}
	}
}
