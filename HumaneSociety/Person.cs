using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    abstract class Person
    {
        Random animalPreference = new Random();
        public string name;
        public int age;
        public string occupation;
        public string homeType;
        public bool hasMoneyForAdoption;
        public bool adopt;

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

        public void TestAnimalPreference()
        {
            //adjust if necessary
            int randomAnimal = animalPreference.Next(0, 100);
            if (randomAnimal <= 20)
            {
                //cat
            }
            if (randomAnimal <40 && randomAnimal >= 21)
            {
                //small dog
            }

            if (randomAnimal <60 && randomAnimal >= 41)
            {
                //medium dog
            }

            if (randomAnimal <61 && randomAnimal >= 80)
            {
                //large dog
            }
            if (randomAnimal <81 && randomAnimal >= 90)
            {
                //iguana
            }
            if (randomAnimal < 90)
            {
                //dragon
            }

        }

        public bool AdoptAnimal()
        {
            //if all conditions are met then they can adopt animal in question
            return adopt;
        }

        public void RemoveAnimalFromList()
        {

        }
    }
}
