using Battlee.Enums;
using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Models.Equipment.Weapons
{
    class Axe : IWeapon
    {
        public string Name { get; set; }

        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int NeedStrength { get; set; }

        public Rarity Rarity { get; set; }

        public Axe(string name, int minDamage, int maxDamage, int needStrength, Rarity rarity)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            NeedStrength = needStrength;
            Rarity = rarity;
        }
    }
}
