using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    abstract class Animal
    {
        //put either tryParse/tryInt or try catch for user input
        public string animalName;
        public int animalAge;
        public double adoptionPrice;
        public double weeklyPoundsFood;      
             
        public string GetAnimalName()
        {
            Console.WriteLine("Enter Animal's Name:");
            animalName = Console.ReadLine();
            return animalName;
        }

        public int GetAnimalAge()
        {
            Console.WriteLine("Enter estimated age of Animal:");
            animalAge = int.Parse(Console.ReadLine());
            return animalAge;
        }

        public double SetAdoptionPrice()
        {
            Console.WriteLine("Enter Adoption Price:");
            adoptionPrice = double.Parse(Console.ReadLine());
            return adoptionPrice;
        }

        public double DetermineWeeklyNeededFood()
        {
            //set amount per size of animal??
            return weeklyPoundsFood;
        }

    }

    
}
