using Battlee.Entities.Enemies;
using Battlee.Entities.Characters;
using Battlee.Entities.Weapons;
using Battlee.Interfaces;
using Battlee.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Battlee.Enums;

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
            var rarity = Rarity.Rare;

            return new Axe(name, minDamage, maxDamage, needStrength, rarity);
        }

        private static ICharacter CreateCharacter()
        {
            var name = "Arthur";
            var health = 100;
            var strength = 15;
            var protection = 14;

            return new Character(name, health, strength, protection);
        }

        private static void SimulateBattle(ICharacter character)
        {
            IEnemy enemy = new Troll("Ugly Goerk", 1000, 27, Element.None);

            while (character.Health > 0 && enemy.Health > 0)
            {
                if (character.Health > 0 && enemy.Health > 0)
                    bc.Hit(character, enemy);

                if (character.Health > 0 && enemy.Health > 0)
                    bc.Hit(enemy, character);
            }
        }
    }
}
