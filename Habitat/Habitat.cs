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
            public string biome;
            public int capacity;
            public double temperature;
            public double size;
            public bool isClean;
            public List<animal> animalsInHabitat;



            public habitat(String biome, int capacity, double tempture, double size, bool isClean)
            {
                this.biome = biome;
                this.capacity = capacity;
                this.temperature = tempture;
                this.size = size;
                this.isClean = isClean;
                this.animalsInHabitat = new List<animal>();
            }

            public string displayInfo()
            {
                return $"Biome: {biome}, Capacity: {capacity}, Temperature: {temperature}C, Size: {size}sqm, Clean: {isClean}, Animals Count: {animalsInHabitat.Count}";
            }
        }
    
    
        public void AddAnimalToHabitat(animal animalToAdd)
        {
            // Logic to add animal to habitat
            AddAnimalToHabitat(animalToAdd);
        }






    }

}
