using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Person
    {
        public string name;
        public string preferredAnimal;
        public string occupation;
        public string homeType;
        public bool adopted;
        public int age;
        public int choice;
        public Person()
        {
            name = InputPersonName();
            preferredAnimal = InputAnimalPreference();
            occupation = InputPersonOccupation();
            homeType = GetHomeType();
            age = InputPersonAge();
        }

        public string InputPersonName()
        {
            Console.WriteLine("Please enter the Name of the person making Adoption:");
            name = Console.ReadLine();
            return name;
        }

        public int InputPersonAge()
        {
            //if less than 18, print cannot adopt, restart user input
            Console.WriteLine("Please enter the Age of the person making Adoption");
            age = int.Parse(Console.ReadLine());
            return age;
        }

        public string InputPersonOccupation()
        {
            Console.WriteLine("Please enter the Occupation of the person making Adoption:");
            occupation = Console.ReadLine();
            return occupation;
        }

        public string GetHomeType()
        {
            Console.WriteLine("Please enter the closest type of Home for the person making Adoption:");
            Console.WriteLine("1=Apartment, 2=Duplex, 3=House, 4=Castle");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    homeType = "apartment";
                    break;
                case 2:
                    homeType = "duplex";
                    break;
                case 3:
                    homeType = "house";
                    break;
                case 4:
                    homeType = "castle";
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered an invalid entry. Please try again.");
                    return GetHomeType();
            }

            return homeType;
        }

        public string InputAnimalPreference()
        {
            Console.WriteLine("Please enter the Animal Preference for the person making Adoption");
            Console.WriteLine("1=Cat, 2=Dog, 3=Iguana, 4=Dragon");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    preferredAnimal = "cat";
                    break;
                case 2:
                    preferredAnimal = "dog";
                    break;
                case 3:
                    preferredAnimal = "iguana";
                    break;
                case 4:
                    preferredAnimal = "dragon";
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered an invalid entry. Please try again.");
                    return InputAnimalPreference();
            }

            return preferredAnimal;
        }

        public bool AdoptAnimal()
        {
            //if all conditions are met then they can adopt animal in question
            RemoveAnimalFromList();
            return adopted;
        }

        public void RemoveAnimalFromList()
        {
        }
    }
}