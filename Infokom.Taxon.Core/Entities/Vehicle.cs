namespace Infokom.Taxon.Core.Entities
{
	public class Vehicle 
	{
		public Guid Id { get; set; }
		public string Plate { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public Guid? DriverId { get; set; }
	}

}
