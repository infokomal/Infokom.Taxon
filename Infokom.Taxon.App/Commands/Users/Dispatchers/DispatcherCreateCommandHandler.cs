using AutoMapper;
using Infokom.Taxon.Core.Entities.Users;
using Infokom.Taxon.Data;
using MediatR;

namespace Infokom.Taxon.App.Commands.Users.Dispatchers
{
	public class DispatcherCreateCommandHandler : IRequestHandler<DispatcherCreateCommand, Guid>
	{
		private readonly TaxonDbContext _context;
		private readonly IMapper _mapper;

		public DispatcherCreateCommandHandler(TaxonDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public Task<Guid> Handle(DispatcherCreateCommand request, CancellationToken cancellationToken)
		{
			var dispatcher = _mapper.Map<Dispatcher>(request);
			dispatcher.Id = Guid.NewGuid(); // manually set if ignored in profile
			_context.Dispatchers.Add(dispatcher);
			return _context.SaveChangesAsync(cancellationToken).ContinueWith(t => dispatcher.Id, cancellationToken);
		}
	}
}


