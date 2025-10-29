using System;
using System.Collections.Generic;

namespace ZooPal
{
    internal class Aquarium : Habitat
    {
        public double WaterSalinity { get; set; }
        public double WaterVolume { get; set; }
        public bool HasUnderwaterViewingArea { get; set; }

        public Aquarium(string biome, int capacity, double temperature, double size, bool isClean,
                        double waterVolume, double waterSalinity, bool hasUnderwaterViewingArea)
            : base(biome, capacity, temperature, size, isClean)
        {
            WaterVolume = waterVolume;
            WaterSalinity = waterSalinity;
            HasUnderwaterViewingArea = hasUnderwaterViewingArea;
        }

        public string DisplayAquariumInfo()
        {
            return $"{DisplayInfo()}, Water Volume: {WaterVolume}L, Salinity: {WaterSalinity} ppt, Underwater Viewing: {HasUnderwaterViewingArea}";
        }
    }
}
    public Aquarium(String biome, int capacity, double temperature, double size, bool isClean, double waterVolume, double waterSalinity, bool hasUnderwaterViewingArea)
        : base(biome, capacity, temperature, size, isClean)
        {
            this.waterVolume = waterVolume;
            this.waterSalinity = waterSalinity;
            this.hasUnderwaterViewingArea = hasUnderwaterViewingArea;
        }
    
        public bool CanAccommodate (Animal animal)
        {
            return true;
        }

        public void AddAnimal(Animal animal)
        {

        }

        public void DisplayInfo()
        {

        }

        public void PerformMaintainence()
        {

        }

}
