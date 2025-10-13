using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Program
    {

        static void Main(string[] args)
        {
           animal myAnimal = new animal("Leo", "lion", 5, 190.5, true, DateTime.Now.AddHours(-3), "Savannah");

           Console.WriteLine(myAnimal.displayInfo());

            //display animals
            Console.WriteLine(myAnimal);
            //display habitats
            Console.WriteLine(myHabitats);
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
