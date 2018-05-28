using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanConsole
{
    class HumanConsole
    {
        static void Main()
        {
            Human avatar = new Human("Janusz", "Kowalski", 20);

            avatar.PrintData();
            Console.ReadLine();
        }
    }
}
