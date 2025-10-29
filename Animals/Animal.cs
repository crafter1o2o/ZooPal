using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    class Animal
    {
        //All the Varaibles needed for the Animal class
        private String animalName;
        private int animalAge;
        private double animalWeight;
        private bool isHealthy;
        private DateTime LastFed;
        private string habitatType;

        //Constructor for the Animal class
        public Animal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat)
        {
            this.animalName = name;
            this.animalAge = age;
            this.animalWeight = weight;
            this.isHealthy = healthy;
            this.LastFed = lastFed;
            this.habitatType = habitat;
        }
        //Method to display the info of the Animal
        public void displayInfo()
        {
             Console.WriteLine($"Name: {animalName}, Age: {animalAge}, Weight: {animalWeight}kg, Healthy: {isHealthy}, Last Fed: {LastFed}, Habitat: {habitatType}");
        }
    }
}