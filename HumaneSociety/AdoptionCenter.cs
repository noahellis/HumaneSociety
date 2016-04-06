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
        public void DisplayAllAnimals()
        {
            Console.WriteLine("Cats:");
            catCageList.ForEach(Console.WriteLine);
            Console.WriteLine("Dogs:");
            dogCageList.ForEach(Console.WriteLine);
            Console.WriteLine("Iguanas:");
            terrariumList.ForEach(Console.WriteLine);
            Console.WriteLine("Dragons:");
            dragonPenList.ForEach(Console.WriteLine);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
        public void DisplayRemainingCatCages()
        {
            int remainingCatCages = 40 - catCageList.Count;
            Console.WriteLine("Remaining cat cages: {0}" , remainingCatCages);
        }
        public void DisplayRemainingDogCages()
        {
            int remainingDogCages = 20 - dogCageList.Count;
            Console.WriteLine("Remaining dog cages: {0}", remainingDogCages);
        }
        public void DisplayRemainingTerrariums()
        {
            int remainingTerrariums = 15 - terrariumList.Count;
            Console.WriteLine("Remaining terrariums: {0}", remainingTerrariums);
        }
        public void DisplayRemainingDragonPens()
        {
            int remainingDragonPens = 3 - dragonPenList.Count;
            Console.WriteLine("Remaining cat cages: {0}", remainingDragonPens);
        }
    } 


}
