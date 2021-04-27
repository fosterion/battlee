using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Controllers
{
    class BattleController
    {
        private readonly DamageCalculation dc;

        public BattleController()
        {
            dc = new DamageCalculation();
        }

        internal void Hit(ICharacter character, IEnemy enemy)
        {
            var damage = dc.GetDamageToEnemy(character);

            if (enemy.Health - damage >= 0)
            {
                enemy.Health -= damage;
                Console.WriteLine($"[{character.Name}] hits [{enemy.Name}] by [{damage}] damage." +
                    $"\n\tCharacter has: [{character.Health}] HP" +
                    $"\n\tEnemy has: [{enemy.Health}] HP");
            }
            else
            {
                enemy.Health = 0;
                Console.WriteLine($"[{character.Name}] kills [{enemy.Name}]." +
                    $"\n\tCharacter has: [{character.Health}] HP" +
                    $"\n\tEnemy has: [{enemy.Health}] HP");
            }
        }

        internal void Hit(IEnemy enemy, ICharacter character)
        {
            var damage = dc.GetDamageToCharacter(enemy, character);

            if (character.Health - damage >= 0)
            {
                character.Health -= damage;
                Console.WriteLine($"[{enemy.Name}] hits [{character.Name}] by [{damage}] damage." +
                    $"\n\tCharacter has: [{character.Health}] HP" +
                    $"\n\tEnemy has: [{enemy.Health}] HP");
            }
            else
            {
                character.Health = 0;
                Console.WriteLine($"[{enemy.Name}] kills [{character.Name}]." +
                    $"\n\tCharacter has: [{character.Health}] HP" +
                    $"\n\tEnemy has: [{enemy.Health}] HP");
            }
        }
    }
}
