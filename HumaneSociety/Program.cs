using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        UserInterface runProgram = new UserInterface();
        static void Main(string[] args)
        {
            UserInterface testUserInterface = new UserInterface();
            testUserInterface.StartInterface();
            Console.ReadKey();
        }
    }
}
