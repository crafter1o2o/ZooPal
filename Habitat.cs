using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Habitat
    {
        public class habitat
        {
            // This is a mock of the Hierarchy
            private string biome;
            private int capacity;
            private double temperature;
            private double size;
            private bool isClean;
            private List<animal> animalsInHabitat;



            public habitat(String biome, int capacity, double tempture, double size, bool isClean){
                this.biome = biome;
                this.capacity = capacity;
                this.temperature = tempture;
                this.size = size;
                this.isClean = isClean;
                this.animalsInHabitat = new List<animal>();
            }

            public string displayInfo()
            {
                return $"Name: {animalName}, Species: {species}, Age: {animalAge}, Weight: {animalWeight}kg, Healthy: {isHealthy}, Last Fed: {LastFed}, Habitat: {habitatType}";
            }
        }
    }
}
