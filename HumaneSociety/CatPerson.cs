using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CatPerson : Person
    {
        Random catRandom = new Random();
        bool likesCats;
        bool hasCatAllergy;
        public CatPerson()
        {
            
            preferredAnimal = "Cats";
            
        }    
               
    }
}
