using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    public abstract class animal
    {
        // This is a mock of the Hierarchy
        private string animalName;
        private int animalAge;
        private double animalWeight;
        private bool isHealthy;
        private DateTime LastFed;
        private string habitatType;

        public animal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat)
        {
            this.animalName = name;
            this.animalAge = age;
            this.animalWeight = weight;
            this.isHealthy = healthy;
            this.LastFed = lastFed;
            this.habitatType = habitat;
        }

        public string MakeSound()
        {

        }
        
        public string GetDietType()
        {

        }

        public double GetFoodAmount()
        {

        }

        public void Feed()
        {

        }
        
        public void PerformHealthCheck()
        {

        }

        public void displayInfo()
        {
             Console.WriteLine($"Name: {animalName}, Age: {animalAge}, Weight: {animalWeight}kg, Healthy: {isHealthy}, Last Fed: {LastFed}, Habitat: {habitatType}");
        }
    }
}