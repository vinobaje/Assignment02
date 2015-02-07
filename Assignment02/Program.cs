using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            SuperHero superHero = new SuperHero("super Hero");
            superHero.showPowers();
            superHero.fight();
            Console.WriteLine("***********************************");
            Console.WriteLine("press any key");

            Console.ReadKey();

        }
    }
}