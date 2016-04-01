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
    }
}
