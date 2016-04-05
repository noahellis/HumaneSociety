using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class AnimalContainer
    {
        Animal animalCages;
        public List<Animal> animalAdoptionList = new List<Animal>();
        public bool isOccupied;
        public int size;
        public int number;
        public void CheckForOpenContainer()
        {
            //maybe move to each type of cage..
            if (isOccupied)
            {
                Console.WriteLine("This Animal Container is occupied.");
            }

            else
            {
                Console.WriteLine("This Animal Container is open.");
            }
        }

        public bool PutAnimalIn()
        {
            isOccupied = true;
            return isOccupied;
        }

        public void ClearCage()
        {
            //when animal is adopted
        }
    }
}
