using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.Weapons
{
    class FlameHammer : IWeapon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int NeedStr { get; set; }

        public FlameHammer(string name, int damage, int needStr)
        {
            Name = name;
            Damage = damage;
            NeedStr = needStr;
        }
    }
}
