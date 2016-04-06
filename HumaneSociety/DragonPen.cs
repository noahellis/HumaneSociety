using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DragonPen : AnimalContainer
    {
        Dragon newDragon = new Dragon();

        public DragonPen()
        {
            size = 500;
            number = 3;

        }
        public void CheckForOpenDragonPen()
        {
            for (int penIndex = 0; penIndex < number; penIndex++)
            {
                if (isOccupied)
                {
                    Console.WriteLine("This Dragon Pen is Occupied");
                }
            }
            
        }
    }
}
