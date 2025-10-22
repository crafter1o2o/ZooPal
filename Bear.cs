using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Bear : Mamnal
    {
        bool likesHoney;

        public Bear(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat, bool isSocial, int gestationDays, bool likesHoney)
        {
            this.likesHoney = likesHoney;
        }
    }
    
}
