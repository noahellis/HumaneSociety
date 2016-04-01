using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DogPerson : Person
    {
        bool likesDogs;
        bool hasDogAllergy;
        bool hasSpaceForDog;
        string desiredSize;

        public bool TestSpaceForDog()
        {
            return hasSpaceForDog;
        }

        public bool TestLikesDogs()
        {
            return likesDogs;
        }

        public bool TestDogAllergy()
        {
            return hasDogAllergy;
        }

        public string GetDesiredSize()
        {
            return desiredSize;
        }
    }
}
