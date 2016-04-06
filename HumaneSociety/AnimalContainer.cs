using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class AnimalContainer
    {
        public Animal animalCages;        
        public bool isOccupied;
        public int size;
        public int number;
       

        public bool PutAnimalIn()
        {
            isOccupied = true;
            return isOccupied;
        }

        public void ClearCage()
        {
          
        }
       
    }
}
