using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ZooPal.Habitat;

namespace ZooPal
{
    internal class Preserve
    {
        String name;
        List<String> animals;
        List<String> habitats;
        DateTime OpeningTime;
        DateTime ClosingTime;
        bool isRecentlyFed;

        public string Name;
        public List<Animal> Animals;
        public List<Habitat> Habitat;
        public DateTime OpeningTime;
        public DateTime ClosingTime;

        public Preserve(string name)
        {
            this.Name = name;
        }

        public void AddAnimal(animal Animal)
        {

        }

        public void AddHabitat(habitat Habitat)
        {

        }

        public void FeedAllAnimals()
        {
            
        }

        public void PerformHealthChecks()
        {

        }

        public void DisplayAllAnimals()
        {

        }

        public void DisplayAllHabitats()
        {

        }


        public void GenerateDailyReport()
        {

        }

        public void EmergencyEvacuation()
        {

        }









    }
}