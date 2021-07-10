using Battlee.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Shared.Interfaces
{
    interface IEnemy
    {
        string Name { get; set; }

        int Health { get; set; }

        int MinDamage { get; set; }

        int MaxDamage { get; set; }

        Element Element { get; set; }
    }
}
