using System;

namespace ZooPal
{
    internal class Animal
    {
        // Backing fields for properties to avoid ambiguity
        public readonly string _name;
        public readonly int _age;
        public readonly double _weight;
        public bool _isHealthy;
        public DateTime _lastFed;
        public readonly string _habitatType;

        // Properties for the Animal class
        public string Name => _name;
        public int Age => _age;
        public double Weight => _weight;
        // To fix CS0101, ensure only one definition of 'Animal' exists in the 'ZooPal' namespace.
        // If you have another 'Animal' class in the same namespace (possibly in another file), you must remove or rename one of them.
        // If this file is the intended definition, delete or rename the duplicate 'Animal' class elsewhere in your project.
        // No code changes are needed in this file unless you want to rename this class.

        //
        // If you need help locating the duplicate, search your project for "class Animal" in the 'ZooPal' namespace.
        //
        public bool IsHealthy => _isHealthy;
        public DateTime LastFed => _lastFed;
        public string HabitatType => _habitatType;

        // Constructor
        public Animal(string name, int age, double weight, bool isHealthy, DateTime lastFed, string habitatType)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _isHealthy = isHealthy;
            _lastFed = lastFed;
            _habitatType = habitatType;
        }

        // Method to display the animal's information
        public void DisplayInfo()
        {
            Console.WriteLine(
                $"Name: {_name}, Age: {_age}, Weight: {_weight} kg, Healthy: {_isHealthy}, Last Fed: {_lastFed:g}, Habitat: {_habitatType}"
            );
        }

        // Optional: helper methods
        public void Feed()
        {
            _lastFed = DateTime.Now;
            Console.WriteLine($"{_name} has been fed.");
        }

        public void UpdateHealth(bool healthStatus)
        {
            _isHealthy = healthStatus;
            Console.WriteLine($"{_name}'s health status updated to: {_isHealthy}");
        }
    }
}
