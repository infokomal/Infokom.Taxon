using AutoMapper;
using Infokom.Taxon.Core.Entities.Users;
using Infokom.Taxon.Data;
using MediatR;

namespace Infokom.Taxon.App.Commands.Users.Drivers
{
	public class DriverCreateCommandHandler : IRequestHandler<DriverCreateCommand, Guid>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;
		public DriverCreateCommandHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public Task<Guid> Handle(DriverCreateCommand request, CancellationToken cancellationToken)
		{
			var driver = _mapper.Map<Driver>(request);
			driver.Id = Guid.NewGuid(); // manually set if ignored in profile
			_context.Drivers.Add(driver);
			return _context.SaveChangesAsync(cancellationToken).ContinueWith(t => driver.Id, cancellationToken);
		}
	}
}


