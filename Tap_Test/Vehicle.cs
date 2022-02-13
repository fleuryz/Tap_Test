using System;
using System.Collections.Generic;

namespace Tap_Test
{

	public enum VehicleType
	{
		ANY,
		TAXI
	}

	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class VehicleDriver
	{

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public VehicleType Type { get; set; }
		public int BaseFarePrice { get; set; }
		public int BaseFareDistance { get; set; }
		public Dictionary<FareInfo, int> SavedFares { get; set; }

		public VehicleDriver(string name, string surname, string email, VehicleType type, int baseFarePrice, int baseFareDistance)
		{
			SavedFares = new Dictionary<FareInfo, int>();
			Name = name;
			Surname = surname;
			Email = email;
			Type = type;
			BaseFarePrice = baseFarePrice;
			BaseFareDistance = baseFareDistance;

		}

		public int GetCost(FareInfo fareInfo)
		{
            if (SavedFares.TryGetValue(fareInfo, out int farePrice))
                return farePrice;
            switch (Type)
			{
				case VehicleType.TAXI:
					farePrice = BaseFarePrice + (int)Math.Floor((float)GetDistanceTraveledByUnit(fareInfo.DistanceTraveled, fareInfo.TravelUnit) * (float)fareInfo.CostPerDistance);
					SavedFares.Add(fareInfo, farePrice);
					return farePrice;
				default:
					throw new ArgumentException($"Transportation of {Type} cannot have its fare cost determined.");
			}
		}

		private float GetDistanceTraveledByUnit(int distanceTraveled, int travelUnit)
		{
			return distanceTraveled > BaseFareDistance ? (float)(distanceTraveled - BaseFareDistance) / (float)travelUnit : 0f;
		}

        public override string ToString() => $"{Surname}, {Name} ({Email}): {Type} driver. Base Distance: {BaseFareDistance} | Base Price: {BaseFarePrice}";

		public string ToSaveString() => $"{Surname},{Name},{Email},{Type},{BaseFarePrice},{BaseFareDistance}";

		public string ToListString() => $"{Surname}, {Name}: {Type} driver";

		public string FullName() => $"{Surname}, {Name}";
	}
}