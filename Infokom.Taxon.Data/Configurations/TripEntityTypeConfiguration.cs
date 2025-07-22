using Infokom.Taxon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Taxon.Data.Configurations
{
	public class TripEntityTypeConfiguration : IEntityTypeConfiguration<Trip>
	{
		public void Configure(EntityTypeBuilder<Trip> builder)
		{
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Source).IsRequired().HasMaxLength(64);
			builder.Property(t => t.Target).IsRequired().HasMaxLength(64);
			builder.Property(t => t.Price).IsRequired();
			builder.Property(t => t.Distance).IsRequired();
			builder.Property(t => t.Duration).IsRequired();
		}
	}
}

