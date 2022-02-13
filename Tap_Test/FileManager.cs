using System;
using System.Collections.Generic;
using System.IO;

namespace Tap_Test
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public static class FileManager
    {
        public static List<FareInfo> GetFares(string fileLocation)
        {
            List<FareInfo> fares = new List<FareInfo>();
            using (var reader = new StreamReader(fileLocation))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var distance = int.Parse(values[0]);
                    var unit = int.Parse(values[1]);
                    var cost = int.Parse(values[2]);

                    fares.Add(new FareInfo(distance, unit, cost));
                }
            }
            return fares;
        }
    }
}