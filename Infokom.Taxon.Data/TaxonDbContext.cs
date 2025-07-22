using Infokom.Taxon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Infokom.Taxon.Data
{
	public class TaxonDbContext : DbContext
	{
		public TaxonDbContext(DbContextOptions<TaxonDbContext> options) : base(options) { }

		public DbSet<Vehicle> Vehicles { get; set; }
		public DbSet<Driver> Drivers { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Trip> PredefinedTrips { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				// Default fallback connection string
				optionsBuilder.UseSqlServer("Server=localhost;Database=InfokomTaxon;Trusted_Connection=True;MultipleActiveResultSets=true");
			}
		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaxonDbContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}
	}
}

