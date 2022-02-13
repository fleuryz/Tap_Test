﻿using System;
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
		public Dictionary<FareInfo, float> SavedFares { get; set; }

		public VehicleDriver(string name, string surname, string email, VehicleType type, int baseFarePrice, int baseFareDistance)
		{
			SavedFares = new Dictionary<FareInfo, float>();
			Name = name;
			Surname = surname;
			Email = email;
			Type = type;
			BaseFarePrice = baseFarePrice;
			BaseFareDistance = baseFareDistance;

		}

		public float GetCost(FareInfo fareInfo)
		{
            if (SavedFares.TryGetValue(fareInfo, out float farePrice))
                return farePrice;
            switch (Type)
			{
				case VehicleType.TAXI:
					farePrice = BaseFarePrice + GetDistanceTraveledByUnit(fareInfo.DistanceTraveled, fareInfo.TravelUnit) * fareInfo.CostPerDistance;
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

		public string ToSaveString() => $"{Surname},{Name},{Email},{Type},{BaseFarePrice},{BaseFareDistance}\n";

		public string ToListString() => $"{Surname}, {Name}: {Type} driver";

		public string FullName() => $"{Surname}, {Name}";
	}
}