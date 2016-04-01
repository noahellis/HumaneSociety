using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dragon : Animal
    {
        int dragonPower;
        string dragonTemperament;
        public Dragon (string animalName, int animalAge, double adoptionPrice, double weeklyPoundsFood, int dragonPower, string dragonTEmperament)
        {

        }
        public int InputDragonPower()
        {
            return dragonPower;
        }

        public string InputDragonTemperament()
        {
            return dragonTemperament;
        }
    }
}
