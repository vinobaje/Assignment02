using System;
using System.Linq;


namespace Assignment02
{
    class SuperHero : Hero
    {
        string[] superPowers;
        public SuperHero(string name): base(name)
        {
            generateAbilities();
        }
        private void generateAbilities()
        {
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
            string[] Powers = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            string PowerValue;
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Random rnd = new Random();
            superPowers = new string[3];

        }
    }
}