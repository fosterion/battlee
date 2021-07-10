using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Shared.Interfaces
{
    interface IProtagonist
    {
        string Name { get; set; }

        int Health { get; set; }

        int Strength { get; set; }

        int Protection { get; set; }

        IWeapon Weapon { get; set; }

        IWeapon DefaultWeapon { get; set; }
    }
}
