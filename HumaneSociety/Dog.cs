using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dog : Animal
    {
        string dogBreed;
        string dogSize;
        string dogTemperament;
        bool dogHasShots;
        public Dog (string animalName, int animalAge, double adoptionPrice, double weeklyPoundsFood, string dogBreed, string dogSize, string dogTemperament)            
        {

        }
        public string InputDogBreed()
        {
            return dogBreed;
        }

        public string InputDogSize()
        {
            return dogSize;
        }

        public string GetDogTemprament()
        {
            return dogTemperament;
        }

        public bool CheckDogShots()
        {
            return dogHasShots;
        }

        public void GiveDogShots()
        {
            dogHasShots = true;
        }
    }
}
