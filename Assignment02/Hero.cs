using System;

namespace Assignment02
{
    class Hero
    {
        //++++++++++++++++++++++++++++Private Properties+++++++++++++++++++++++++++++

        private int strength;

        private int speed;

        private int health;
        //++++++++++++++++++++++++++++Public Properties+++++++++++++++++++++++++++++

        public string name;

        //++++++++++++++++++++++++++++constructor+++++++++++++++++++++++++++++++++++++

        public Hero(string name)
        {

            this.name = name;

            generateAbilities();

        }

        //++++++++++++++++++++++++++++Private methods+++++++++++++++++++++++++++++

        private void generateAbilities()
        {

            Random rnd = new Random();

            strength = rnd.Next(1, 100);

            speed = rnd.Next(1, 100);

            health = rnd.Next(1, 100);

        }

        private bool hitAttempt()
        {

            Random rnd = new Random();



            if (rnd.Next(1, 6) == 1)
            {

                return true;

            }

            else
            {

                return false;

            }
        }
            private int hitDamage()

        {

            Random rnd = new Random();

            return (strength * rnd.Next(1, 6));

            //int damage = strength * 5;

            //Console.WriteLine("The damage is: {0}", damage);

            //return damage;

        }


            //++++++++++++++++++++++++++++Public methods+++++++++++++++++++++++++++++

            public void fight()
            {



                if (hitAttempt() == true)
                {

                    hitDamage();

                }

                else
                {



                }

            }


            public void show()
            {

                Console.WriteLine("The strength is: {0}", strength);

                Console.WriteLine("The speed is: {0}", speed);

                Console.WriteLine("The health is: {0}", health);

            }
     }
}

