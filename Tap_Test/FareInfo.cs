using System;

namespace Tap_Test
{
	public class FareInfo
	{
		public int DistanceTraveled { get; set; }
		public int TravelUnit { get; set; }
		public int CostPerDistance { get; set; }

		public FareInfo(int distanceTraveled, int travelUnit, int costPerDistance)
		{
			DistanceTraveled = distanceTraveled;
			TravelUnit = travelUnit;
			CostPerDistance = costPerDistance;
		}

		public string ToListString() => $"Distance: {DistanceTraveled}; Unit: {TravelUnit}; Cost: {CostPerDistance}";
	}
}