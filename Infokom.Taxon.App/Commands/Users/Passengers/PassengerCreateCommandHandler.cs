using AutoMapper;
using Infokom.Taxon.Core.Entities.Users;
using Infokom.Taxon.Data;
using MediatR;

namespace Infokom.Taxon.App.Commands.Users.Passengers
{
	public class PassengerCreateCommandHandler : IRequestHandler<PassengerCreateCommand, Guid>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;
		public PassengerCreateCommandHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public Task<Guid> Handle(PassengerCreateCommand request, CancellationToken cancellationToken)
		{
			var passenger = _mapper.Map<Passenger>(request);
			passenger.Id = Guid.NewGuid(); // manually set if ignored in profile
			_context.Passengers.Add(passenger);
			return _context.SaveChangesAsync(cancellationToken).ContinueWith(t => passenger.Id, cancellationToken);
		}

	}
}


