using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    public class animal
    {
        // This is a mock of the Higharchy
        String animalName;
        int animalAge;
        double animalWeight;
        bool isHealthy;
        DateTime LastFed;
        String habitatType;

        public animal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat)
        {
            this.animalName = name;
            this.animalAge = age;
            this.animalWeight = weight;
            this.isHealthy = healthy;
            this.LastFed = lastFed;
            this.habitatType = habitat;
        }

        void displayInfo()
        {
            Console.WriteLine("Name: " + animalName);
            Console.WriteLine("Age: " + animalAge);
            Console.WriteLine("Weight: " + animalWeight);
            Console.WriteLine("Healthy: " + isHealthy);
            Console.WriteLine("Last Fed: " + LastFed);
            Console.WriteLine("Habitat Type: " + habitatType);
        }
    }
}