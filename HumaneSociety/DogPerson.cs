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
      
        public bool hasSpaceForDog;
        public string desiredSize;
        
        
        public DogPerson()
        {
           
            desiredSize = GetDesiredSize();
            hasSpaceForDog = TestSpaceForApartment();         
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
                
            }

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

    }
}
