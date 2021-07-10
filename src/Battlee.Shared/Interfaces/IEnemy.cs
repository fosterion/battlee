using Battlee.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Interfaces
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
