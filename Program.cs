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

           animal myAnimal = new animal("Leo", "Lion", 5, 190.5, true, DateTime.Now.AddHours(-3), "Savannah");



            Console.WriteLine(myAnimal.displayInfo());
            Console.WriteLine(myAnimal);




            //ben here
            //Mark Balatro
        }
    }
}
