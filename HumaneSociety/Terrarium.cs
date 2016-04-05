using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Terrarium : AnimalContainer
    {       
        List<AnimalContainer> terrarium = new List<AnimalContainer>();

        public Terrarium()
        {
            size = 15;
            number = 20;
        }
        public void FillOneTerrarium()
        {
            if (animalCages.animalType.Equals("iguana"))
            {
                if (number > 0)
                {
                    if (animalCages.animalType.Equals("Iguana", StringComparison.CurrentCultureIgnoreCase))
                    { number -= 1; }
                }
                else if (number <= 0)
                {
                    Console.WriteLine("You do not have enough space for this Iguana.");
                }
            }                              
        }

        public void EmptyOneTerrarium()
        {

        }
    }
}
