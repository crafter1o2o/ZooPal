using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{.
    internal class Aviary
    {
        public class Aviary : Habitat
        {
            public double FightHeight;
            public int Perchcount;
            public bool HasNettingRoof;
        }

        public Aviary(String biome, int capacity, double temperature, double size, bool isClean, double flightHeight, int perchCount, bool hasNettingRoof)
            : base(biome, capacity, temperature, size, isClean)
        {
            this.FightHeight = flightHeight;
            this.Perchcount = perchCount;
            this.HasNettingRoof = hasNettingRoof;
        }
    }
}
