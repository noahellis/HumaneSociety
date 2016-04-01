using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    abstract class Person
    {
        public string name;
        public int age;
        public string occupation;
        public string homeType;
        public bool hasMoneyForAdoption;

        public string InputPersonName()
        {
            return name;
        }

        public int InputPersonAge()
        {
            return age;
        }

        public string InputPersonOccupation()
        {
            return occupation;
        }

        public string GetHomeType()
        {
            return homeType;
        }

        public void TestAnimalPreference()
        {

        }

        public void AdoptAnimal()
        {

        }

        public void RemoveAnimalFromList()
        {

        }
    }
}
