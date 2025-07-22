using AutoMapper;
using Infokom.Taxon.App.Mappers;
using Infokom.Taxon.Core.Entities;
using Infokom.Taxon.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infokom.Taxon.App.Commands.Drivers
{
	public class CreateDriverCommandHandler : IRequestHandler<CreateDriverCommand, Guid>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public CreateDriverCommandHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<Guid> Handle(CreateDriverCommand request, CancellationToken cancellationToken)
		{
			var driver = _mapper.Map<Driver>(request);
			driver.Id = Guid.NewGuid(); // manually set if ignored in profile

			_context.Drivers.Add(driver);
			await _context.SaveChangesAsync(cancellationToken);

			return driver.Id;
		}
	}
}
