using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Animal
    {
        //put either tryParse/tryInt or try catch for user input
        public string animalName;
        public string animalType;
        public double animalAge;
        public double adoptionPrice;
        public double weeklyPoundsFood;
       
        public  Animal()
        {
            animalName = GetAnimalName();
            animalAge = GetAnimalAge();
            adoptionPrice = SetAdoptionPrice();
        }
             
        public string GetAnimalName()
        {
            Console.WriteLine("Enter Animal's Name:");
            animalName = Console.ReadLine();
            return animalName;
        }

        public double GetAnimalAge()
        {
            Console.WriteLine("Enter estimated age of Animal in years:");
            animalAge = double.Parse(Console.ReadLine());
            return animalAge;
        }

        public double SetAdoptionPrice()
        {
            Console.WriteLine("Enter Adoption Price:");
            adoptionPrice = double.Parse(Console.ReadLine());
            return adoptionPrice;
        }
    }    
}
