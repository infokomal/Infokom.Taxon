namespace Infokom.Taxon.Core.Entities
{
	public class Trip 
	{
		public Guid Id { get; set; }
		public string Source { get; set; }
		public string Target { get; set; }
		public decimal Price { get; set; }
		public double Distance { get; set; }
		public TimeSpan Duration { get; set; }
	}

}
