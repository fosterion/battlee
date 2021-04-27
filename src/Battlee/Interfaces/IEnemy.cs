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

        double Damage { get; set; }

        Element Element { get; set; }
    }
}
