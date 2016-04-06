using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Terrarium : AnimalContainer
    {
        Iguana newIguana = new Iguana();

        public Terrarium()
        {
            size = 15;
            number = 20;
            
        }
       
    }
}
