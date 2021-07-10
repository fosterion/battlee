using Battlee.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Interfaces
{
    interface IWeapon
    {
        string Name { get; set; }

        int MinDamage { get; set; }

        int MaxDamage { get; set; }

        int NeedStrength { get; set; }

        Rarity Rarity { get; set; }
    }
}
