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
        public bool hasMoneyForAdoption;
        public bool adopt;
        public int age;

        public string InputPersonName()
        {
            Console.WriteLine("Please enter the Name of the person making Adoption:");
            name = Console.ReadLine();
            return name;
        }

        public int InputPersonAge()
        {
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
            Console.WriteLine("Please enter the type of Home for the person making Adoption:");
            homeType = Console.ReadLine();
            return homeType;
        }

        public string InputAnimalPreference()
        {
            Console.WriteLine("Please enter the Animal Preference for the person making Adoption");
            Console.WriteLine("Choices:Cat, Dog, Iguana, Dragon");
            preferredAnimal = Console.ReadLine();
            return preferredAnimal;

        }

        public bool AdoptAnimal()
        {
            //if all conditions are met then they can adopt animal in question
            RemoveAnimalFromList();
            return adopt;
        }

        public void RemoveAnimalFromList()
        {

        }
    }
}
