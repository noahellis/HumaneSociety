using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class UserInterface
    {
        AdoptionCenter runInterface;
        public UserInterface()
        {
            runInterface = new AdoptionCenter();
        }
        public string preferredAnimal;
        
        public void AddDogPerson()
        {
            Person dogPerson = new DogPerson();
            runInterface.adopterList.Add(dogPerson);
        }
        public void AddCatPerson()
        {
            Person catPerson = new CatPerson();
            runInterface.adopterList.Add(catPerson);
        }
        public void AddIguanaPerson()
        {
            Person iguanaPerson = new IguanaPerson();
            runInterface.adopterList.Add(iguanaPerson);
        }
        public void AddDragonPerson()
        {
            Person dragonPerson = new DragonPerson();
            runInterface.adopterList.Add(dragonPerson);
        }
        public string PickPreferredAnimal()
        {       
            Console.WriteLine("Please enter the Animal Preference for the person making Adoption");
            Console.WriteLine("1=Cat, 2=Dog, 3=Iguana, 4=Dragon");
            int choice =int.Parse(Console.ReadLine());
            switch (choice)
            {
                //make these start constructor
                case 1:
                    preferredAnimal = "cat";
                    AddCatPerson();
                    break;
                case 2:
                    preferredAnimal = "dog";
                    AddDogPerson();
                    break;
                case 3:
                    preferredAnimal = "iguana";
                    AddIguanaPerson();
                    break;
                case 4:
                    preferredAnimal = "dragon";
                    AddDragonPerson();
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered an invalid entry. Please try again.");
                    return PickPreferredAnimal();
            }

            return preferredAnimal;
        }
    
        public void AddAnimal()
        {
        }

        public void AdoptAnimal()
        {
        }

        public void StartInterface()
        {
            Console.WriteLine("Enter the number that corresponds with what you would like to do:");
            Console.WriteLine("1: Enter new Animal for Adoption");
            Console.WriteLine("2: Enter new Adopting Person");
            Console.WriteLine("3: Perform Adoption");
            Console.WriteLine("4: Remove Adopting Person from list");
            Console.WriteLine("5: Check available Animal Container space");
            Console.WriteLine("6: Check for weekly food needed");
            Console.WriteLine("7: Print list of current Animals in Shelter");
            Console.WriteLine("8: Exit Program");
            activateInterface();
        }

        public void activateInterface()
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddAnimal();
                    break;
                case 2:
                    PickPreferredAnimal();
                    break;
                case 3:
                    AdoptAnimal();
                    break;
                case 4:
                    //remove person from list
                    break;
                case 5:
                    //check cage availability
                    break;
                case 6:
                    //check for weekly food
                    break;
                case 7:
                    //print list of animals in shelter
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}