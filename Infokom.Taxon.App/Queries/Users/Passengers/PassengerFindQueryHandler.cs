using AutoMapper;
using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Taxon.App.Queries.Users.Passengers
{
	public class PassengerFindQueryHandler : IRequestHandler<PassengerFindQuery, PassengerModel>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public PassengerFindQueryHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<PassengerModel> Handle(PassengerFindQuery request, CancellationToken cancellationToken)
		{
			var entity = await _context.Passengers.FirstOrDefaultAsync(d => d.Username == request.Username, cancellationToken);

			var model = entity is null ? null : _mapper.Map<PassengerModel>(entity);

			return model;
		}
	}
}
