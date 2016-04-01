using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CatPerson : Person
    {
        bool likesCats;
        bool hasCatAllergy;
        string desiredPattern; //calico, solid, striped, etc

        public bool TestLikesCats()
        {
            return likesCats;
        }

        public bool TestCatAllergy()
        {
            return hasCatAllergy;
        }

        public string GetDesiredPattern()
        {
            return desiredPattern;
        }
    }
}
