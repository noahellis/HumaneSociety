using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class LargeCage : AnimalContainer
    {        
        List<AnimalContainer> largeCage = new List<AnimalContainer>();

        public LargeCage()
        {
            size = 30;
            number = 10;
        }
    }
}
