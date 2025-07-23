using Infokom.Taxon.Core.Atomics;
using Infokom.Taxon.Core.Entities;
using Infokom.Taxon.Core.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Taxon.Data.Configurations
{
	public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasIndex(u => u.Username)
				.IsUnique();


			builder.HasDiscriminator(x => x.Type)
				.HasValue<Passenger>(Role.Client)
				.HasValue<Driver>(Role.Driver)
				.HasValue<Dispatcher>(Role.Dispatcher);
		}
	}
}

