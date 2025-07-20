using System.Collections.Generic;
using AL.OnTaxi.Web.Client.Models;

namespace AL.OnTaxi.Web.Client.Data
{
	public class TripRepository
	{
		private readonly Dictionary<string, LocationInfo> _locations = new()
		{
			["Vlorë"] = new LocationInfo { Name = "Vlorë", Coordinates = (40.454602, 19.484542) },
			["Kaninë"] = new LocationInfo { Name = "Kaninë", Coordinates = (40.4431, 19.4897) },
			["Panaja"] = new LocationInfo { Name = "Panaja", Coordinates = (40.4892, 19.5312) },
			["Radhimë"] = new LocationInfo { Name = "Radhimë", Coordinates = (40.3931, 19.4786) },
			["Zvërnec"] = new LocationInfo { Name = "Zvërnec", Coordinates = (40.5072, 19.4006) },
			["Orikum"] = new LocationInfo { Name = "Orikum", Coordinates = (40.3331, 19.4717) },
			["Tragjas"] = new LocationInfo { Name = "Tragjas", Coordinates = (40.323682, 19.510902) },
			["Dukat"] = new LocationInfo { Name = "Dukat", Coordinates = (40.252243, 19.565015) },
			["Llogara"] = new LocationInfo { Name = "Llogara", Coordinates = (40.2206, 19.5631) },
			["Palasë"] = new LocationInfo { Name = "Palasë", Coordinates = (40.1592718, 19.6020328) },
			["Dhërmi"] = new LocationInfo { Name = "Dhërmi", Coordinates = (40.1531, 19.6342) },
			["Himarë"] = new LocationInfo { Name = "Himarë", Coordinates = (40.1022, 19.7447) },
			["Sarandë"] = new LocationInfo { Name = "Sarandë", Coordinates = (39.8756, 20.0059) },
			["Ksamil"] = new LocationInfo { Name = "Ksamil", Coordinates = (39.8667, 20.0167) },
			["Fier"] = new LocationInfo { Name = "Fier", Coordinates = (40.7239, 19.5561) },
			["Berat"] = new LocationInfo { Name = "Berat", Coordinates = (40.7058, 19.9522) },
			["Gjirokastër"] = new LocationInfo { Name = "Gjirokastër", Coordinates = (40.0758, 20.1389) },
			["Korçë"] = new LocationInfo { Name = "Korçë", Coordinates = (40.6186, 20.7808) },
			["Kukës"] = new LocationInfo { Name = "Kukës", Coordinates = (42.0769, 20.4219) },
			["Shkodër"] = new LocationInfo { Name = "Shkodër", Coordinates = (42.0683, 19.5126) },
			["Durrës"] = new LocationInfo { Name = "Durrës", Coordinates = (41.3231, 19.4414) },
			["Elbasan"] = new LocationInfo { Name = "Elbasan", Coordinates = (41.1125, 20.0828) },
			["Lezhë"] = new LocationInfo { Name = "Lezhë", Coordinates = (41.7836, 19.6436) },
			["Peshkopi"] = new LocationInfo { Name = "Peshkopi", Coordinates = (41.6850, 20.4281) },
			["Tirana"] = new LocationInfo { Name = "Tirana", Coordinates = (41.3275, 19.8187) },
			["TIA Airport 🛫"] = new LocationInfo { Name = "TIA Airport 🛫", Coordinates = (41.4147, 19.7206) },
			["Prishtinë"] = new LocationInfo { Name = "Prishtinë", Coordinates = (42.6629, 21.1655) },
		};

		public IReadOnlyDictionary<string, LocationInfo> Locations => _locations;

		public List<TripGroup> GetTripGroups()
		{
			return new List<TripGroup>
			 {
				new TripGroup
				{
				    Group = "📍 Local Trips (0–25 km)",
				    Trips = new List<TripInfo>
				    {
					   new() { Source = _locations["Vlorë"], Target = _locations["Kaninë"], Cost = 1000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Panaja"], Cost = 1500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Radhimë"], Cost = 1200 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Zvërnec"], Cost = 1500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Orikum"], Cost = 1500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Tragjas"], Cost = 2500 },
				    }
				},
				new TripGroup
				{
				    Group = "🌊 Southbound Coastal Trips",
				    Trips = new List<TripInfo>
				    {
					   new() { Source = _locations["Vlorë"], Target = _locations["Dukat"], Cost = 3000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Llogara"], Cost = 3500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Palasë"], Cost = 3500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Dhërmi"], Cost = 4000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Himarë"], Cost = 5000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Sarandë"], Cost = 8000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Ksamil"], Cost = 9000 },
				    }
				},
				new TripGroup
				{
				    Group = "🧭 Inland & Long-Distance Trips",
				    Trips = new List<TripInfo>
				    {
					   new() { Source = _locations["Vlorë"], Target = _locations["Fier"], Cost = 2500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Berat"], Cost = 5000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Gjirokastër"], Cost = 6000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Korçë"], Cost = 16000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Kukës"], Cost = 15500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Shkodër"], Cost = 13500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Durrës"], Cost = 6000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Elbasan"], Cost = 7500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Lezhë"], Cost = 12500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Peshkopi"], Cost = 15000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Tirana"], Cost = 8000 },
					   new() { Source = _locations["Vlorë"], Target = _locations["TIA Airport 🛫"], Cost = 7500 },
					   new() { Source = _locations["Vlorë"], Target = _locations["Prishtinë"], Cost = 20000 },
				    }
				}
			 };
		}
	}
}
