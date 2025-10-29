using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Savanna: Habitat
    {
        double GrassCoverage;
        int WateringHole;
    }

    public Savanna(String biome, int capacity, double temperature, double size, bool isClean, double grassCoverage, int wateringHole)
        : base(biome, capacity, temperature, size, isClean)
    {
        this.GrassCoverage = grassCoverage;
        this.WateringHole = wateringHole;
        }

    }
