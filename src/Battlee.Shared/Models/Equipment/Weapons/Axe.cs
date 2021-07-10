using Battlee.Shared.Enums;
using Battlee.Shared.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Shared.Models.Equipment.Weapons
{
    class Axe : Weapon
    {
        public Axe(string name, int minDamage, int maxDamage, int needStrength, Rarity rarity)
            : base(name, minDamage, maxDamage, needStrength, rarity)
        {

        }
    }
}
