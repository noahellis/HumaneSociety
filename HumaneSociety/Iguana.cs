using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Iguana : Animal
    {
        
        string iguanaColor;
        string iguanaLifeStage;

        public Iguana ()
        {            
            iguanaLifeStage = InputIguanaLifeStage();
            iguanaColor = InputIguanaColor();
            weeklyPoundsFood = .3;
            animalType = "Iguana";
        }      
        public string InputIguanaColor()
        {
            Console.WriteLine("Please input the Color of the Iguana");
            iguanaColor = Console.ReadLine();
            return iguanaColor;
        }

        public string InputIguanaLifeStage()
        {
            Console.WriteLine("Please enter the life stage of the iguana. (Juvenile or Adult)");
            iguanaLifeStage = Console.ReadLine();
            return iguanaLifeStage;
        }
    }
}
