using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Iguana : Animal
    {
        string iguanaColor;
        string iguanaSize;

        public Iguana (string animalName, int animalAge, double adoptionPrice, double weeklyPoundsFood, string iguanaColor, string iguanaSize)
        {

        }
        public string InputIguanaColor()
        {
            return iguanaColor;
        }

        public string InputIguanaSize()
        {
            return iguanaSize;
        }
    }
}
