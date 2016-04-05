using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DogPerson : Person
    {
        Random dogRandom = new Random();
        public bool likesDogs;
        public bool hasDogAllergy;
        public bool hasSpaceForDog;
        public string desiredSize;
        
        
        public DogPerson()
        {
            //might have to make these flow from one function to the other, instead of calling them all here..
            desiredSize = GetDesiredSize();
            hasSpaceForDog = TestSpaceForApartment();            
            likesDogs = TestLikesDogs();
            hasDogAllergy = TestDogAllergy();
            preferredAnimal = "Dogs";
            
        }
        public bool TestSpaceForApartment()
        {
            if (homeType.Equals("apartment", StringComparison.CurrentCultureIgnoreCase))
            {
                if (desiredSize.Equals ("Small", StringComparison.CurrentCultureIgnoreCase)||desiredSize.Equals("Medium" , StringComparison.CurrentCultureIgnoreCase)) 
                {
                    Console.WriteLine("Person has enough room for the {0} dog.", desiredSize);
                    hasSpaceForDog = true;
                }
                else if (desiredSize.Equals("Large", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Person does not have enough room for the {0} dog.", desiredSize);
                    hasSpaceForDog = false;
                    TryDifferentSizeDog();
                }               
            }
            else
            {
                TestSpaceForDuplex();
            }       
            return hasSpaceForDog;
        }    
            
        public bool TestSpaceForDuplex()
        {
            if (homeType.Equals ("duplex", StringComparison.CurrentCultureIgnoreCase))
            {
                if (desiredSize.Equals("Small", StringComparison.CurrentCultureIgnoreCase) || desiredSize.Equals("Medium", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Person has enough room for the dog.");
                    hasSpaceForDog = true;
                }
                else if (desiredSize.Equals("Large", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Person does not have enough room for the dog.");
                    hasSpaceForDog = false;
                    TryDifferentSizeDog();
                }
            }
            else
            {
                TestSpaceForHouseAndCastle();
            }       
            return hasSpaceForDog;
        }
        public bool TestSpaceForHouseAndCastle()
        {
            if (homeType.Equals("house", StringComparison.CurrentCultureIgnoreCase) || homeType.Equals("Castle", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Person has enough room for the dog.");
                hasSpaceForDog = true;
            }
            return hasSpaceForDog;
        }
        public void TryDifferentSizeDog()
        {
            Console.WriteLine("Would you like to try a different sized dog?");
            string choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                GetDesiredSize();
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                //exit to selection screen
            }

        }
        public bool TestLikesDogs()
        {
            int likeDogDeterminer = dogRandom.Next(0, 50);
            if (likeDogDeterminer <= 15)
            {
                Console.WriteLine("After watching this person interact with a Dog, it seems like they do not like Dogs.");
                likesDogs = false;
                
            }
            else if (likeDogDeterminer > 15)
            {
                Console.WriteLine("After watching this person interact with a Dog, it seems they love dogs.");
                likesDogs = true;                          
            }
            return likesDogs;
        }

        public bool TestDogAllergy()
        {
            int hasDogAllergyDeterminer = dogRandom.Next(0, 50);
            if (hasDogAllergyDeterminer <= 20)
            {
                Console.WriteLine("Shortly after interacting with a Dog, this person starts to sneeze and wheeze.");
                Console.WriteLine("They seem to be allergic to dogs.");
                hasDogAllergy = true;
            }
            else if (hasDogAllergyDeterminer > 20)
            {
                Console.WriteLine("This person has been interacting with a dog for a while, with no adverse effects.");
                Console.WriteLine("They do not seem to be allergic to Dogs");
                hasDogAllergy = false;
            }
            return hasDogAllergy;
        }

        public string GetDesiredSize()
        {
            Console.WriteLine("What size dog would the person like? (1=Small, 2=Medium, 3=Large)");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    desiredSize = "small";
                    break;
                case 2:
                    desiredSize = "medium";
                    break;
                case 3:
                    desiredSize = "large";
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered an invalid entry. Please try again.");
                    return GetDesiredSize();
            }
            return desiredSize;
        }
        public void AddDogPersonToList()
        {
            
        }
    }
}
