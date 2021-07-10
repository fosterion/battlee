using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Controllers
{
    class DamageCalculation
    {
        internal int GetDamageToEnemy(IProtagonist hero)
        {
            var baseDamage = new Random().Next(hero.Weapon.MinDamage, hero.Weapon.MaxDamage);
            var strength = hero.Strength;
            var needStrength = hero.Weapon.NeedStrength;

            return baseDamage * strength / (strength > needStrength ? strength - needStrength : needStrength);
        }

        internal int GetDamageToCharacter(IEnemy enemy, IProtagonist hero)
        {
            var damage = new Random().Next(enemy.MinDamage, enemy.MaxDamage);
            var protection = hero.Protection;

            return damage / protection * 10;
        }
    }
}
