using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero myHero = new Hero("Vino");

            myHero.show();

            myHero.fight();



            Console.WriteLine("press any key");

            Console.ReadKey();

        }
    }
}