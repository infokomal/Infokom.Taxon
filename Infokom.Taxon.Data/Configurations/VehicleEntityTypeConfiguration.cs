using Infokom.Taxon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Taxon.Data.Configurations
{
	public class VehicleEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
	{
		public void Configure(EntityTypeBuilder<Vehicle> builder)
		{
			builder.HasKey(v => v.Id);
			builder.Property(v => v.Plate).IsRequired().HasMaxLength(16);
			builder.Property(v => v.Model).IsRequired().HasMaxLength(64);
			builder.Property(v => v.Brand).IsRequired().HasMaxLength(64);
			builder.Property(v => v.Color).IsRequired().HasMaxLength(64);
		}
	}
}

