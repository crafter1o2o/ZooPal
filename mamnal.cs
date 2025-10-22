using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Mamnal : Animal {
        bool isSocial;
        int gestationDays;

        public Mamnal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat, bool isSocial, int gestationDays)
        { 

            this.isSocial = isSocial;
            this.gestationDays = gestationDays;

        }





    }
}
