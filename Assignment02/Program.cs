using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero myHero = new Hero("Vino");

            myHero.show();

            myHero.fight();


            SuperHero superHeroMan = new SuperHero("super Hero Man");
            superHeroMan.showPowers();
            superHeroMan.fight();

            Console.WriteLine("press any key");

            Console.ReadKey();

        }
    }
}