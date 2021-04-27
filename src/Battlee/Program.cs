using Battlee.Entities.Characters;
using Battlee.Entities.Weapons;
using Battlee.Interfaces;
using Battlee.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Battlee.Enums;
using System.Threading.Tasks;
using System.Threading;

namespace Battlee
{
    class Program
    {
        private static BattleController bc;

        static void Main(string[] args)
        {
            bc = new BattleController();

            var hero = CreateCharacter();
            hero.Weapon = GiveWeapon();
            SimulateBattle(hero);

            Console.ReadKey();
        }

        private static IWeapon GiveWeapon()
        {
            var name = "Rusty axe";
            var minDamage = 17;
            var maxDamage = 24;
            var needStrength = 14;
            var rarity = EnumGenerator.GetRandom<Rarity>();

            return new Axe(name, minDamage, maxDamage, needStrength, rarity);
        }

        private static ICharacter CreateCharacter()
        {
            var name = "Arthur";
            var health = 100;
            var strength = 15;
            var protection = 14;

            return new Hero(name, health, strength, protection);
        }

        private static void SimulateBattle(ICharacter hero)
        {
            IEnemy enemy = new Enemy("Ugly Goerk", 1000, 24, 33, EnumGenerator.GetRandom<Element>());

            while (hero.Health > 0 && enemy.Health > 0)
            {
                if (hero.Health > 0 && enemy.Health > 0)
                    bc.Hit(hero, enemy);

                Thread.Sleep(100);

                if (hero.Health > 0 && enemy.Health > 0)
                    bc.Hit(enemy, hero);

                Thread.Sleep(100);
            }
        }
    }
}
