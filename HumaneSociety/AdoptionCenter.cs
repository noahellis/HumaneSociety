using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AdoptionCenter
    {
        List<Animal> animalAdoptionList = new List<Animal>();
        List<Person> adopterList = new List<Person>();
        bool isAdopted;

        public void AddAdoptionList()
        {
            //here is where to start. figure out how to add new user inputted people/animals to the list
        }

        public void RemoveAdoptionList()
        {
            //animalAdoptionList.Remove();
        }

        public bool AdoptAnimal()
        {
            RemoveAdoptionList();
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
