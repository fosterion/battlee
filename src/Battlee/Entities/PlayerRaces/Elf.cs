using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.PlayerRaces
{
    class Elf : IPlayer
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public int Protection { get; set; }

        public IWeapon Weapon { get; set; }

        public Elf(string name, int health, int strength, int protection, IWeapon weapon)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Protection = protection;
            Weapon = weapon;
        }
    }
}
