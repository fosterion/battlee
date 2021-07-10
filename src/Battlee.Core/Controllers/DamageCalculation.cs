using Battlee.Shared.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Controllers
{
    class DamageCalculation
    {
        internal int GetDamageToEnemy(Protagonist hero)
        {
            var baseDamage = new Random().Next(hero.Weapon.MinDamage, hero.Weapon.MaxDamage);
            var strength = hero.Strength;
            var needStrength = hero.Weapon.NeedStrength;

            return baseDamage * strength / (strength > needStrength ? strength - needStrength : needStrength);
        }

        internal int GetDamageToCharacter(Enemy enemy, Protagonist hero)
        {
            var damage = new Random().Next(enemy.MinDamage, enemy.MaxDamage);
            var protection = hero.Protection;

            return damage / protection * 10;
        }
    }
}
