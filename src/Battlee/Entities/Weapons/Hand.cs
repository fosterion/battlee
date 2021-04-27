using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.Weapons
{
    class Hand : IWeapon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int NeedStr { get; set; }

        public Hand()
        {
            Name = "Рука";
            Damage = 1;
            NeedStr = 1;
        }
    }
}
