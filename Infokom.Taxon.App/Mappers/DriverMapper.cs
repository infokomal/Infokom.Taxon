using AutoMapper;
using Infokom.Taxon.App.Commands.Users.Drivers;
using Infokom.Taxon.App.Models.Users;
using Infokom.Taxon.Core.Entities.Users;
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
			this.CreateMap<DriverCreateCommand, Driver>()
			    .ForMember(dest => dest.Id, opt => opt.Ignore());

			// Driver mappings
			this.CreateMap<Pass, DriverModel>()
				.ReverseMap();
			this.CreateMap<DriverCreateCommand, Driver>()
			    .ForMember(dest => dest.Id, opt => opt.Ignore());

			// Driver mappings
			this.CreateMap<Driver, DriverModel>()
				.ReverseMap();
			this.CreateMap<DriverCreateCommand, Driver>()
			    .ForMember(dest => dest.Id, opt => opt.Ignore());
		}
	}

}
