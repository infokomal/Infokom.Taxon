using Infokom.Taxon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Taxon.Data.Configurations
{
	public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<Client>
	{
		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.FullName).IsRequired().HasMaxLength(64);
			builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(16);
			builder.Property(c => c.Username).IsRequired().HasMaxLength(64);
			builder.Property(c => c.PasswordHash).IsRequired();
		}
	}
}

