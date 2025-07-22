using Infokom.Taxon.App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Taxon.App.Queries.Drivers
{
	public class SearchDriversByNameQuery : IRequest<List<DriverModel>>
	{
		public string Name { get; set; }

		public SearchDriversByNameQuery(string name)
		{
			this.Name = name;
		}
	}
}
