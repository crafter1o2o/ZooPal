using System;
using System.Collections.Generic;
using System.ComponentModel;
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


            //List for the ALL animals
            List<String> listAnimals = new List<String>();



            //Create the Animal of choice
            animal lion1 = new animal("Leo", "lion", 5, 190.5, true, DateTime.Now.AddHours(-3), "Savannah");



            //Add the animal to the list
            ///I Unfortunately don't know how to automatically add animals to habitats yet, so for now it's manual. -PCB
            listAnimals.Add(lion1.displayInfo());



            //Create Habitats
            ///I will be figuring out how to add animals to habitats automatically later. For now, it's manual. -PCB
            habitat savannahHabitat = new Habitat.habitat("Savannah", 10, 30.0, 5000.0, true);

            //To Stop The Program, Make this bish false
            bool isRunning = true;


            //Take user input
            String userInput;
            string userInput1;



            if (isRunning == true)
            {
                //Makes the menu display
                UI.DisplayMenu();

                Console.Write("Please select an option (1-8): ");
                userInput = Console.ReadLine();
                userInput1 = userInput;
                ///YES I KNOW IT'S REPEATIVE! BUT THIS IS WORKING!!! -PCB

                Console.Clear();
                switch (userInput1)
                {
                    case "1":
                        for (int i = 0; i < 1; i++)
                        {
                            Console.WriteLine(listAnimals[i]);
                        }

                        //Display Animals
                        userInput = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        //Display Habitats
                        Console.WriteLine(savannahHabitat.displayInfo());
                        //Currently, no animals being made are being adding animals to habitat, fix that somehow, figuture it out soon.

                        break;
                    case "3":
                        //Feed All Animals
                        break;
                    case "4":
                        //Perform Health Checks
                        break;
                    case "5":
                        //Add New Animal
                        break;
                    case "6":
                        //Generate Daily Report
                        break;
                    case "7":
                        //Emergency Evacuation Drill
                        break;
                    case "8":
                        //Exit
                        isRunning == false;
                        Goodbye.displayGoodbye();
                        Enviroment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
        }
    }
}

          
            //display animals
           
           



            //display habitats

            //feed all animals

            //perform health checks
            //add new animal

            //Generate Daily Report
            //Demonstrate Polymorphism
            //Emergency Evactuation Drill
            //Exit

