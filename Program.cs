using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZooPal.Habitat;

namespace ZooPal
{
    internal class Program
    {

        static void Main(string[] args)
        {
            habitat savannahHabitat = new Habitat.habitat("Savannah", 10, 30.0, 5000.0, true);
            animal lion1 = new animal("Leo", "lion", 5, 190.5, true, DateTime.Now.AddHours(-3), "Savannah");


            Console.WriteLine(savannahHabitat.displayInfo());
            //Currently, no animals being made are being adding animals to habitat, fix that somehow, figuture it out soon.
            Console.WriteLine("\n");

            Console.WriteLine(lion1.displayInfo());
            

            //display animals
           
           



            //display habitats

            //feed all animals

            //perform health checks
            //add new animal

            //Generate Daily Report
            //Demonstrate Polymorphism
            //Emergency Evactuation Drill
            //Exit
        }
    }
}
