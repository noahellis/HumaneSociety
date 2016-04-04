using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class IguanaPerson : Person
    {
        bool hasTerrarium;
        bool hasIguanaCareKnowledge;
        string choice;
        string desiredIguanaColor;
        public IguanaPerson()
        {
            hasTerrarium = TestHasTerrarium();
            hasIguanaCareKnowledge = TestHasIguanaCareKnowledge();
            desiredIguanaColor = GetDesiredIguanaColor();
        }

        public bool TestHasTerrarium()
        {
            Console.WriteLine("Does the Adopting Person have proof of owning a Terrarium?");
            choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                hasTerrarium = true;
            }
            else if (choice.Equals ("no", StringComparison.CurrentCultureIgnoreCase))
            {
                hasTerrarium = false;
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return TestHasTerrarium();
            }
            return hasTerrarium;
        }

        public bool TestHasIguanaCareKnowledge()
        {
            Console.WriteLine("Does the Adopting Person have knowledge of Iguana Care?");
            choice = Console.ReadLine();
            if (choice.Equals ("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                hasIguanaCareKnowledge = true;
            }
            else if (choice.Equals ("no", StringComparison.CurrentCultureIgnoreCase))
            {
                hasIguanaCareKnowledge = false;
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return TestHasIguanaCareKnowledge();
            }
            return hasIguanaCareKnowledge;
        }

        public string GetDesiredIguanaColor()
        {
            Console.WriteLine("Please enter the Adopting Person's desired Iguana Color");
            desiredIguanaColor = Console.ReadLine();
            return desiredIguanaColor;
        }
    }
}
