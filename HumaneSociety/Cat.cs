using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Cat : Animal
    {
        string catColorPatern;
        string catSize;
        string catTemperament;
        bool catHasShots;

        public Cat (string animalName, int animalAge, double adoptionPrice, double weeklyPoundsFood, string catColorPattern, string catSize, string catTeperament, bool catHasShots)
        {

        }

        public string InputCatcolorPattern()
        {
            return catColorPatern;
        }

        public string InputCatSize()
        {
            return catSize;
        }

        public string GetCatTemperament()
        {
            return catTemperament;
        }

        public bool CheckCatShots()
        {
            return catHasShots;
        }

        public void GiveCatShots()
        {
            catHasShots = true;
        }
    }
}
