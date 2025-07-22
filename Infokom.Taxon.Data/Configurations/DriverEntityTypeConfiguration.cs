using Infokom.Taxon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Taxon.Data.Configurations
{
	public class DriverEntityTypeConfiguration : IEntityTypeConfiguration<Driver>
	{
		public void Configure(EntityTypeBuilder<Driver> builder)
		{
			builder.HasKey(d => d.Id);
			builder.Property(d => d.FullName).IsRequired().HasMaxLength(64);
			builder.Property(d => d.PhoneNumber).IsRequired().HasMaxLength(16);
			builder.Property(d => d.Username).IsRequired().HasMaxLength(64);
			builder.Property(d => d.PasswordHash).IsRequired();
		}
	}
}

