using System;
using System.Collections.Generic;
using System.Linq;

namespace Tap_Test
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class DriverList
	{
		public List<VehicleDriver> Drivers { get; set; }

		public DriverList()
		{
			Drivers = new List<VehicleDriver>();
		}

		public void AddTaxiDriver(VehicleDriver driver)
        {
			Drivers.Add(driver);
        }

		public (float, string) FindLowestFare(FareInfo fare, VehicleType type = VehicleType.ANY)
        {
            try
            {
				VehicleDriver driver = Drivers.Where(x => type == VehicleType.ANY || x.Type == type).OrderBy(driver => driver.GetCost(fare)).First();
				return (driver.GetCost(fare), driver.FullName());
            }
            catch
            {
				throw new Exception("No drivers available for that query.");
            }
        }

		public VehicleDriver GetDriverByIndex(int index)
        {
			return Drivers[index];
        }

		public string FindLowestFareSaveString(FareInfo fare, VehicleType type = VehicleType.ANY)
        {
			try
			{
				VehicleDriver driver = Drivers.Where(x => type == VehicleType.ANY || x.Type == type).OrderBy(driver => driver.GetCost(fare)).First();
				var cost = driver.GetCost(fare);
				var driverString = driver.ToSaveString();
				return $"{cost},{driverString}";
			}
			catch
			{
				throw new Exception("No drivers available.");
			}
		}


	}
}