using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Aquarium : Habitat
    {
        double waterSalinity;
        double waterVolume;
        bool hasUnderwaterViewingArea;

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
