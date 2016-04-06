using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DogCage : AnimalContainer
    {
        Dog newDog = new Dog();

        public DogCage()
        {
            size = 20;
            number = 20;
        }
    }
}
