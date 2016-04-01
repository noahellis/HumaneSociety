using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class SmallCage : AnimalContainer
    {        
        List<AnimalContainer> smallCage = new List<AnimalContainer>();
        public SmallCage()
        {
            size = 10;
            number = 30;
        }
    }
}
