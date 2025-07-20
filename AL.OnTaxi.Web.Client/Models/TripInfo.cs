using System.Collections.Generic;

namespace AL.OnTaxi.Web.Client.Models
{
	public class TripInfo
	{
	    public LocationInfo Source { get; set; }
	    public LocationInfo Target { get; set; }
	    public int Cost { get; set; }
	}




	public class TripGroup
	{
		public string Group { get; set; }

		public List<TripInfo> Trips { get; set; }
	}
}
