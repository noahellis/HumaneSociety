using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DragonPerson : Person
    {
        bool isHagrid;
        bool isDragonSlayer;
        bool isStrong;
        bool hasCastle;

        public bool TestIsHagrid()
        {
            return isHagrid;
        }

        public bool TestIsDragonSlayer()
        {
            return isDragonSlayer;
        }

        public bool TestIsStrong()
        {
            return isStrong;
        }

        public bool TestHasCastle()
        {
            if (GetHomeType().Equals ("Castle")) 
            {
                hasCastle = true;
            }

            else
            {
                hasCastle = false;

            }
            return hasCastle;
        }
    }
}
