using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Interfaces
{
    interface IMonster
    {
        string Name { get; set; }

        int Health { get; set; }

        int Damage { get; set; }
    }
}
