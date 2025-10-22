using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    class Animal
    {
        // This is a mock of the Hierarchy
        private String animalName;
        private int animalAge;
        private double animalWeight;
        private bool isHealthy;
        private DateTime LastFed;
        private string habitatType;

        public Animal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat)
        {
            this.animalName = name;
            this.animalAge = age;
            this.animalWeight = weight;
            this.isHealthy = healthy;
            this.LastFed = lastFed;
            this.habitatType = habitat;
        }

        public void displayInfo()
        {
             Console.WriteLine($"Name: {animalName}, Age: {animalAge}, Weight: {animalWeight}kg, Healthy: {isHealthy}, Last Fed: {LastFed}, Habitat: {habitatType}");
        }
    }
}