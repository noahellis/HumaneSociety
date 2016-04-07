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
        
        public CatPerson()
        {
            
            preferredAnimal = "Cats";
            
        }    
               
    }
}
