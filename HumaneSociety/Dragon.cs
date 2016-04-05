using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Dragon : Animal
    {
        string dragonTemperament;
        public Dragon ()
        {           
            weeklyPoundsFood = 200;
            dragonTemperament = InputDragonTemperament();
            animalType = "Dragon";
        }      

        public string InputDragonTemperament()
        {
            Console.WriteLine("Please input the dragon Temperament: (Fiery, Smoldering, Ashen");
            dragonTemperament = Console.ReadLine();
            return dragonTemperament;
        }
    }
}
