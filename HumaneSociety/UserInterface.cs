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
        public void AddPerson()
        {
            
        }

        public void AddAnimal()
        {
        }

        public void AdoptAnimal()
        {
        }

        public void StartInterface()
        {
            Console.WriteLine("Enter the following number for what you would like to do:");
            Console.WriteLine("1: Enter new Animal for Adoption");
            Console.WriteLine("2: Enter new Adopting Person");
            Console.WriteLine("3: Perfom Adoption");
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
                    AddPerson();
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