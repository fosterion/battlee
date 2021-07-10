using Battlee.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Shared.Models.Base
{
    class Weapon
    {
        public string Name { get; set; }

        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int NeedStrength { get; set; }

        public Rarity Rarity { get; set; }

        public Weapon(string name, int minDamage, int maxDamage, int needStrength, Rarity rarity)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            NeedStrength = needStrength;
            Rarity = rarity;
        }
    }
}
