using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    class Program
    {
        static Hero MyHero = new Hero
        {
            Name = "Brienne",
            Offense = 4,
            Defense = 2,
            MaxHitPoints = 25,
            HitPoints = 25,
            Gold = 20,
            Inventory = new List<Item>
            {
                new Item
                {
                    Name = "Oathkeeper",
                    Cost = 200,
                    Effects = new Dictionary<string, int>
                    {
                        { "Offense", 6 },
                        { "Defense", 3 },
                        { "Respect", 20 },
                        { "Agility", -2 }
                    }
                },
                new Item
                {
                    Name = "Loaf of Bread",
                    Cost = 1,
                    Effects = new Dictionary<string, int>
                    {
                        { "Wolfiness", 20 },
                    }
                }            }
        };

        static Dragon MyEnemy = new Dragon
        {
            Name = "Drogon",
            Offense = 26,
            Defense = 12,
            MaxHitPoints = 60,
            HitPoints = 60
        };

        static ShopKeeper Higbees = new ShopKeeper(new List<Item>
        {
                new Item
                {
                    Name = "Ring of Great Power",
                    Cost = 17,
                    Effects = new Dictionary<string, int>
                    {
                        { "Offense", 7 }
                    }
                },
                new Item
                {
                    Name = "Cursed Ring",
                    Cost = 4,
                    Effects = new Dictionary<string, int>
                    {
                        { "Offense", 12 },
                        { "Defense", -5 }
                    }
                },
                new Item
                {
                    Name = "Magic Armor",
                    Cost = 17,
                    Effects = new Dictionary<string, int>
                    {
                        { "Defense", 15 }
                    }
                }

        });


        /// <summary>
        /// Runs a battle between a Hero and a Dragon. Ends when one of them has 0 HitPoints.
        /// </summary>
        /// <param name="hero">The Hero in the battle.</param>
        /// <param name="enemy">The Dragon in the battle.</param>
        static void Battle(Hero hero, Dragon enemy)
        {
            // TODO++: modify Battle to take a List<Dragon> of enemies, and have each of them attack every time through the loop.
            // You may want to have the Hero automatically attack the first enemy in the list that is still alive.
            Die myDie = new Die(20);
            Console.WriteLine(MyHero);

            Console.WriteLine("VERSUS");

            Console.WriteLine(MyEnemy);


            while (MyHero.IsAlive())
            {
                int attackRoll = myDie.Roll();
                Console.WriteLine("Rolled {0} for attack phase", attackRoll);
                MyHero.Attack(MyEnemy, attackRoll);
                Console.WriteLine(MyEnemy);

                if (!MyEnemy.IsAlive())
                {
                    Console.WriteLine("{0} slayed {1}!", MyHero.Name, MyEnemy.Name);
                    break;
                }
                int defenseRoll = myDie.Roll();
                Console.WriteLine("Rolled {0} for defense phase", defenseRoll);
                MyHero.Defend(MyEnemy, defenseRoll);
                Console.WriteLine(MyHero);
            }

            if (!MyHero.IsAlive())
            {
                Console.WriteLine("{0} was defeated by {1}. :(", MyHero.Name, MyEnemy.Name);
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("{0} must slay {1} to continue on the journey.", MyHero.Name, MyEnemy.Name);

            Console.WriteLine(MyHero);

            Higbees.Trade(MyHero);

            Battle(MyHero, MyEnemy);

            Console.ReadLine();
        }
    }
}
