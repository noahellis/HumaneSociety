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
        public void StartInterface()
        {
            Console.WriteLine("Enter the number that corresponds with what you would like to do:");
            Console.WriteLine("1: Enter new Animal for Adoption"); //done
            Console.WriteLine("2: Enter new Adopting Person"); //done
            Console.WriteLine("3: Perform Adoption");
            Console.WriteLine("4: Remove Adopting Person from list"); //doneish, need to make it print clearer info
            Console.WriteLine("5: Check available Animal Container space");//done
            Console.WriteLine("6: Check for weekly food needed");//done
            Console.WriteLine("7: Print list of current Animals in Shelter");//done
            Console.WriteLine("8: Exit Program"); //done
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
                    PrintPersonList();
                    RemovePerson();
                    break;
                case 5:
                    ChooseCageToCheck();
                    break;
                case 6:
                    //check for weekly food
                    break;
                case 7:
                    runInterface.DisplayAllAnimals();
                    StartInterface();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }
        }

        public void AddDogPerson()
        {
            Person dogPerson = new DogPerson();
            runInterface.adopterList.Add(dogPerson);
            AskEnterNewPerson();
        }

        public void AddCatPerson()
        {
            Person catPerson = new CatPerson();
            runInterface.adopterList.Add(catPerson);
            AskEnterNewPerson();
        }

        public void AddIguanaPerson()
        {
            Person iguanaPerson = new IguanaPerson();
            runInterface.adopterList.Add(iguanaPerson);
            AskEnterNewPerson();
        }

        public void AddDragonPerson()
        {
            Person dragonPerson = new DragonPerson();
            runInterface.adopterList.Add(dragonPerson);
            AskEnterNewPerson();
        }

        public void AddCat()
        {
            CatCage catCage = new CatCage();
            runInterface.catCageList.Add(catCage);
            AskEnterNewAnimal();
        }

        public void AddDog()
        {
            DogCage dogCage = new DogCage();
            runInterface.dogCageList.Add(dogCage);
            AskEnterNewAnimal();
        }

        public void AddIguana()
        {
            Terrarium iguanaTerrarium = new Terrarium();
            runInterface.terrariumList.Add(iguanaTerrarium);
            AskEnterNewAnimal();
        }

        public void AddDragon()
        {
            DragonPen dragonPen = new DragonPen();
            runInterface.dragonPenList.Add(dragonPen);
            AskEnterNewAnimal();
        }

        public string PickPreferredAnimal()
        {
            Console.WriteLine("Please enter the Animal Preference for the person making Adoption");
            Console.WriteLine("1=Cat, 2=Dog, 3=Iguana, 4=Dragon");
            int choice = int.Parse(Console.ReadLine());
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
                default:
                    Console.WriteLine("Sorry, you have entered an invalid entry. Please try again.");
                    return EnterAnimalType();
            }

            return animalType;
        }
        public int ChooseCageToCheck()
        {
            Console.WriteLine("Which variety of cage would you like to check?");
            Console.WriteLine("1=Cat, 2=Dog, 3=Iguana, 4=Dragon");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CheckCatCageAvailablility();
                    break;
                case 2:
                    CheckDogCageAvailablility();
                    break;
                case 3:
                    CheckTerrariumAvailablility();
                    break;
                case 4:
                    CheckDragonPenAvailablility();
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered an invalid entry. Please try again.");
                    return ChooseCageToCheck();
            }
            return choice;
        }
        public void CheckDogCageAvailablility()
        {
            runInterface.DisplayRemainingDogCages();
            AskCheckAnotherCage();
        }
        public void CheckCatCageAvailablility()
        {
            runInterface.DisplayRemainingCatCages();
            AskCheckAnotherCage();
        }
        public void CheckTerrariumAvailablility()
        {
            runInterface.DisplayRemainingTerrariums();
            AskCheckAnotherCage();
        }
        public void CheckDragonPenAvailablility()
        {
            runInterface.DisplayRemainingDragonPens();
            AskCheckAnotherCage();
        }
        public void AskCheckAnotherCage()
        {
            Console.WriteLine("Would you like to check another Cage type?");
            string choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                ChooseCageToCheck();
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                StartInterface();
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again");
                AskCheckAnotherCage();
            }

        }
        public void AskEnterNewAnimal()
        {
            Console.WriteLine("Would you like to enter another Animal?");
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
                AskEnterNewAnimal();
            }
        }

        public void AdoptAnimal()
        {
        }

        public void PrintPersonList()
        {
            if (runInterface.adopterList.Equals(null))
            {
                Console.WriteLine("No people in list");
            }
            else
            {
                Console.WriteLine("Person List: ");
                for (int adopterIndex = 0; adopterIndex < runInterface.adopterList.Count; adopterIndex++)
                {
                    Console.WriteLine("{0}:{1}", runInterface.adopterList[adopterIndex].name);
                }
            }
        }

        public void RemovePerson()
        {
            if (runInterface.adopterList.Equals(null))
            {
                Console.WriteLine("No people in list");
                StartInterface();
            }
            else
            {
                Console.WriteLine("Please enter number next to person to remove them from the list");
                int choice = int.Parse(Console.ReadLine());
                runInterface.adopterList.RemoveAt(choice);
                Console.WriteLine("Person removed!");
                StartInterface();
            }
        }
    }
}