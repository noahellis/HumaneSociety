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
        //public List<SmallCage> smallCageList = new List<SmallCage>();
        //public List<MediumCage> mediumCageList = new List<MediumCage>(); MAKE THESE ARRAYS WITH SET MAX #
        //public List<LargeCage> largeCageList = new List<LargeCage>();
        //public List<Terrarium> terrariumList = new List<Terrarium>();
        //public List<DragonPen> dragonPenList = new List<DragonPen>();
        public List<Dog> dogList = new List<Dog>();
        public List<Cat> catList = new List<Cat>();
        public List<Iguana> iguanaList = new List<Iguana>();
        public List<Dragon> dragonList = new List<Dragon>();
        bool isAdopted;       
        
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
        public void RemoveAdopterList()
        {
            //adopterList.Remove();
        }
    } 


}
