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
        public string animalType;
        
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
        public void AddCat()
        {
            Cat cat = new Cat();
            runInterface.catList.Add(cat);
            AskEnterNewAnimal();
        }
        public void AddDog()
        {
            Dog dog = new Dog();
            runInterface.dogList.Add(dog);
            AskEnterNewAnimal();
        }
        public void AddIguana()
        {
            Iguana iguana = new Iguana();
            runInterface.iguanaList.Add(iguana);
            AskEnterNewAnimal();

        }
        public void AddDragon()
        {
            Dragon dragon = new Dragon();
            runInterface.dragonList.Add(dragon);
            AskEnterNewAnimal();
        }
        public string PickPreferredAnimal()
        {       
            Console.WriteLine("Please enter the Animal Preference for the person making Adoption");
            Console.WriteLine("1=Cat, 2=Dog, 3=Iguana, 4=Dragon");
            int choice =int.Parse(Console.ReadLine());
            switch (choice)
            {                
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
        public string EnterAnimalType()
        {
            Console.WriteLine("Please enter the Animal Type for the new Animal");
            Console.WriteLine("1=Cat, 2=Dog, 3=Iguana, 4=Dragon");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    animalType = "Cat";
                    AddCat();
                    break;
                case 2:
                    animalType = "Dog";
                    AddDog();
                    break;
                case 3:
                    animalType = "Iguana";                                        
                    AddIguana();
                    break;
                case 4:
                    animalType = "Dragon";
                    AddDragon();
                    break;
            }
            return animalType;
        } 
        public void AskEnterNewAnimal()
        {
            Console.WriteLine("Would you like to enter another Animal?");
            string choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                EnterAnimalType();
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                StartInterface();
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again");
                AskEnterNewAnimal();
            }
           
        }   
        public void AskEnterNewPerson()
        {
            Console.WriteLine("Would you like to enter another Person?");
            string choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                PickPreferredAnimal();
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                StartInterface();
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again");
                AskEnterNewPerson();
            }
        } 

        public void AdoptAnimal()
        {
        }

        public void StartInterface()
        {
            Console.WriteLine("Enter the number that corresponds with what you would like to do:");
            Console.WriteLine("1: Enter new Animal for Adoption");//done
            Console.WriteLine("2: Enter new Adopting Person");//done
            Console.WriteLine("3: Perform Adoption");
            //look for false boolean in person making adoption
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
                    EnterAnimalType();
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