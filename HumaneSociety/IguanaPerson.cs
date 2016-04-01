using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class IguanaPerson : Person
    {
        bool hasTerrarium;
        bool hasIguanaCareKnowledge;
        string desiredIguanaColor;

        public bool TestHasTerrarium()
        {
            return hasTerrarium;
        }

        public bool HasIguanaCareKnowledge()
        {
            return hasIguanaCareKnowledge;
        }

        public string DesiredIguanaColor()
        {
            return desiredIguanaColor;
        }
    }
}
