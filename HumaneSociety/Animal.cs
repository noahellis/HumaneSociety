using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    abstract class Animal
    {
        public string animalName;
        public int animalAge;
        public double adoptionPrice;
        public double weeklyPoundsFood;      
             
        public string GetAnimalName()
        {
            return animalName;
        }

        public int GetAnimalAge()
        {
            return animalAge;
        }

        public double SetAdoptionPrice()
        {
            return adoptionPrice;
        }

        public double DetermineWeeklyNeededFood()
        {
            return weeklyPoundsFood;
        }

    }

    
}
