using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Managers
{
    class Battle
    {
        internal void Hit(IPlayer player, IMonster monster)
        {
            var baseDamage = player.Weapon.Damage;
            var strengthCoeff = player.Strength;
            var needStr = player.Weapon.NeedStr;

            var damage = baseDamage * strengthCoeff / (strengthCoeff > needStr ? strengthCoeff - needStr : needStr);

            monster.Health -= damage;

            Console.WriteLine($"[{player.Name}] наносит урон [{damage}] монстру [{monster.Name}]." +
                $"\nХП монстра опускается до [{monster.Health}]");
        }

        internal void Hit(IMonster monster, IPlayer player)
        {

        }
    }
}
