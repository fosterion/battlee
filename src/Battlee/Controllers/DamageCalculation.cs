using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Controllers
{
    class DamageCalculation
    {
        internal int GetDamageToEnemy(ICharacter character)
        {
            var baseDamage = new Random().Next((int)character.Weapon.MinDamage, (int)character.Weapon.MaxDamage);
            var strengthCoeff = character.Strength;
            var needStrength = character.Weapon.NeedStrength;

            return baseDamage * strengthCoeff / (strengthCoeff > needStrength ? strengthCoeff - needStrength : needStrength);
        }

        internal int GetDamageToCharacter(IEnemy enemy, ICharacter character)
        {
            var damage = enemy.Damage;
            var protection = character.Protection;

            return (int)Math.Ceiling(damage / protection);
        }
    }
}
