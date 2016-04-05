using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AdoptionCenter
    {
        public Animal animalInterface;
        public Person personInterface;

        public List<Person> adopterList = new List<Person>();
        public List<AnimalContainer> animalContainerList = new List<AnimalContainer>();
        bool isAdopted;       
        //add animals to cages when added, 
        public void AddAnimalAdoptionList()
        {
            
        }

        public void RemoveAnimalAdoptionList()
        {
            //animalAdoptionList.Remove();
        }

        public bool AdoptAnimal()
        {
            RemoveAnimalAdoptionList();
            isAdopted = true;
            return isAdopted;
        }

        public void CollectFee()
        {

        }

        public void AddAdopterList()
        {
            //adopterList.Add();
        }

        public void RemoveAdopterList()
        {
            //adopterList.Remove();
        }
    } 


}
