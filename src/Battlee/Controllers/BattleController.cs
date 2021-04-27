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

        internal void Hit(ICharacter hero, IEnemy enemy)
        {
            var damage = dc.GetDamageToEnemy(hero);

            if (enemy.Health - damage > 0)
            {
                enemy.Health -= damage;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"[{hero.Name}] hits [{enemy.Name}] by [{damage}] damage." +
                    $"\n\tCharacter has: [{hero.Health}] HP / " +
                    $"Enemy has: [{enemy.Health}] HP");
                Console.ResetColor();
            }
            else
            {
                enemy.Health = 0;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"[{hero.Name}] kills [{enemy.Name}]." +
                    $"\n\tCharacter has: [{hero.Health}] HP / " +
                    $"Enemy has: [{enemy.Health}] HP");
                Console.ResetColor();
            }
        }

        internal void Hit(IEnemy enemy, ICharacter hero)
        {
            var damage = dc.GetDamageToCharacter(enemy, hero);

            if (hero.Health - damage > 0)
            {
                hero.Health -= damage;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[{enemy.Name}] hits [{hero.Name}] by [{damage}] damage." +
                    $"\n\tCharacter has: [{hero.Health}] HP / " +
                    $"Enemy has: [{enemy.Health}] HP");
                Console.ResetColor();
            }
            else
            {
                hero.Health = 0;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[{enemy.Name}] kills [{hero.Name}]." +
                    $"\n\tCharacter has: [{hero.Health}] HP / " +
                    $"Enemy has: [{enemy.Health}] HP");
                Console.ResetColor();
            }
        }
    }
}
