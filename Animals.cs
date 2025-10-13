using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    public class animal
    {
        // This is a mock of the Hierarchy
        private string animalName;
        private string species;
        private int animalAge;
        private double animalWeight;
        private bool isHealthy;
        private DateTime LastFed;
        private string habitatType;

        public animal(String name, String species, int age, double weight, bool healthy, DateTime lastFed, String habitat)
        {
            this.animalName = name;
            this.species = species;
            this.animalAge = age;
            this.animalWeight = weight;
            this.isHealthy = healthy;
            this.LastFed = lastFed;
            this.habitatType = habitat;
        }

        public string displayInfo()
        {
            return $"Name: {animalName}, Species: {species}, Age: {animalAge}, Weight: {animalWeight}kg, Healthy: {isHealthy}, Last Fed: {LastFed}, Habitat: {habitatType}";
        }
    }
}