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
        public List<CatCage> catCageList = new List<CatCage>(new CatCage[40]);
        public List<DogCage> dogCageList = new List<DogCage>(new DogCage[20]);
        public List<Terrarium> terrariumList = new List<Terrarium>(new Terrarium[20]);
        public List<DragonPen> dragonPenList = new List<DragonPen>(new DragonPen[3]);

        bool isAdopted;

        public void AddToSmallCage()
        {
            //mediumCageList.Add()
        }
        public void AddToMediumCage()
        {

        }
        public void AddToLargeCage()
        {

        }
        public void AddToTerrarium()
        {

        }
        public void AddToDragonPen()
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
