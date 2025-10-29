using System;
using System.Collections.Generic;

namespace ZooPal
{
    internal class Aviary : Habitat
    {
        public double FlightHeight { get; set; }
        public int PerchCount { get; set; }
        public bool HasNettingRoof { get; set; }

        public Aviary(string biome, int capacity, double temperature, double size, bool isClean,
                      double flightHeight, int perchCount, bool hasNettingRoof)
            : base(biome, capacity, temperature, size, isClean)
        {
            FlightHeight = flightHeight;
            PerchCount = perchCount;
            HasNettingRoof = hasNettingRoof;
        }

        public string DisplayAviaryInfo()
        {
            return $"{DisplayInfo()}, Flight Height: {FlightHeight}m, Perch Count: {PerchCount}, Netting Roof: {HasNettingRoof}";
        }
    }
}
