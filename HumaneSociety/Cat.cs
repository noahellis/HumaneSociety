using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Cat : Animal
    {
        string choice;
        string catBreed;
        string catTemperament;
        bool catHasShots;
        

        public Cat ()
        {            
            weeklyPoundsFood = 2.0;
            catBreed = InputCatBreed();
            catTemperament = GetCatTemperament();
            catHasShots = CheckCatShots();
            animalType = "Cat";
           
        }

        public string InputCatBreed()
        {
            Console.WriteLine("Please input Cat's Breed");
            catBreed = Console.ReadLine();
            return catBreed;
        }     
        public string GetCatTemperament()
        {
            Console.WriteLine("Please input the cats Temperament (Lazy, Active, Aggressive)");
            catTemperament = Console.ReadLine();
            return catTemperament;
        }

        public bool CheckCatShots()
        {
            Console.WriteLine("Has the Cat received the required Shots?");
            choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                catHasShots = true;
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                AskToGiveCatShots();
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return CheckCatShots();
            }
            return catHasShots;
        }

        public bool GiveCatShots()
        {
            Console.WriteLine("You have given the Cat its Shots.");
            catHasShots = true;
            return catHasShots;
        }
        public bool AskToGiveCatShots()
        {
            Console.WriteLine("Would you like to give the Cat its Shots?");
            choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                GiveCatShots();
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                catHasShots = false;
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return AskToGiveCatShots();
            }
            return catHasShots;
             
        }
    }
}
