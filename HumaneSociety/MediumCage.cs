using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class MediumCage : AnimalContainer
    {
        List<AnimalContainer> mediumCage = new List<AnimalContainer>();

        public MediumCage()
        {
            size = 20;
            number = 20;
        }
    }
}
