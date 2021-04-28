using Battlee.Enums;
using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Models.Equipment.Weapons
{
    class Hand : IWeapon
    {
        public string Name { get; set; }

        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int NeedStrength { get; set; }

        public Rarity Rarity { get; set; }

        public Hand()
        {
            Name = "Рука";
            MinDamage = 1;
            MaxDamage = 1;
            NeedStrength = 1;
            Rarity = Rarity.Common;
        }
    }
}
