using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Interfaces
{
    interface IWeapon
    {
        string Name { get; set; }

        int Damage { get; set; }

        int NeedStr { get; set; }
    }
}
