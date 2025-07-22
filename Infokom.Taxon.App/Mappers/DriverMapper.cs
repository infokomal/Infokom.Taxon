using AutoMapper;
using Infokom.Taxon.App.Commands.Drivers;
using Infokom.Taxon.App.Models;
using Infokom.Taxon.Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infokom.Taxon.App.Mappers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			// Driver mappings
			this.CreateMap<Driver, DriverModel>()
				.ReverseMap();
			this.CreateMap<CreateDriverCommand, Driver>()
			    .ForMember(dest => dest.Id, opt => opt.Ignore());

			// Add other mappings here as needed
		}
	}

}
