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

            int choice = int.Parse(Console.ReadLine());
            //switch case for choice input

        }


    }
}
