using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dog : Animal
    {
        string choice;
        string dogBreed;
        string dogSize;
        string dogTemperament;
        bool dogHasShots;
        public Dog (string animalName, int animalAge, double adoptionPrice, double weeklyPoundsFood, string dogBreed, string dogSize, string dogTemperament)            
        {

        }
        public string InputDogBreed()
        {
            Console.WriteLine("Please enter breed of new Dog");
            dogBreed = Console.ReadLine();
            return dogBreed;
        }

        public string InputDogSize()
        {
            Console.WriteLine("Please enter size of Dog (Small, Medium, or Large)");
            dogSize = Console.ReadLine();
            return dogSize;
        }

        public string GetDogTemprament()
        {
            Console.WriteLine("Please enter the Dog's Temprament (Calm, Active, or Aggressive)");
            return dogTemperament;
        }

        public bool CheckDogShots()
        {
            Console.WriteLine("Has the Dog received the required Shots?");
            choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                dogHasShots = true;
            }

            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                AskToGiveDogShots();
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return CheckDogShots();
            }

            return dogHasShots;
        }

        public bool AskToGiveDogShots()
        {
            Console.WriteLine("Would you like to give the Dog its Shots?");
            choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                GiveDogShots();

            }

            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                dogHasShots = false;
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return AskToGiveDogShots();
            }
            return dogHasShots;
        }

        public void GiveDogShots()
        {
            Console.WriteLine("You have given the Dog its shots.");
            dogHasShots = true;
        }
    }
}
