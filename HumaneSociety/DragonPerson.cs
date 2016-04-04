using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DragonPerson : Person
    {
        bool isHagrid;
        bool isDragonSlayer;       
        bool hasCastle;
        string choice;
        public DragonPerson()
        {
            isHagrid = TestIsHagrid();
            isDragonSlayer = TestIsDragonSlayer();
            hasCastle = TestHasCastle();
        }
        public bool TestIsHagrid()
        {
            Console.WriteLine("Is the person trying to Adopt the Dragon Hagrid?");
            choice = Console.ReadLine();
            if (choice.Equals ("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("I don't think Dumbledore wants Dragons at Hogwarts.");
                isHagrid = true;
            }
            else if (choice.Equals ("no", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Good. Dumbledore doesn't want Dragons at Hogwarts.");
                isHagrid = false;
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return TestIsHagrid();
            }
            return isHagrid;
        }

        public bool TestIsDragonSlayer()
        {
            Console.WriteLine("Do you suspect that the Adopting person is a Dragon Slayer?");
            choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Don't give the dragon to them...They just want to practice slaying some Dragon.");
                isDragonSlayer = true;
            }
            else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Good. We would hate to give the dragon to a bad home.");
                isDragonSlayer = false;
            }
            else
            {
                Console.WriteLine("Sorry, you have made an invalid entry. Please try again.");
                return TestIsDragonSlayer();
            }
            return isDragonSlayer;
        }    
        public bool TestHasCastle()
        {
            if (GetHomeType().Equals ("Castle", StringComparison.CurrentCultureIgnoreCase)) 
            {
                hasCastle = true;
                Console.WriteLine("Good, they have a castle. Can't have a dragon in an apartment");
            }

            else
            {
                hasCastle = false;
                Console.WriteLine("They don't have space for a castle...Dragons need huge....tracts of land..");
            }
            return hasCastle;
        }
    }
}
