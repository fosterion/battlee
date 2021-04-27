using Battlee.Entities.Weapons;
using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.Characters
{
    class Character : ICharacter
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public int Protection { get; set; }

        public IWeapon Weapon { get; set; }

        public IWeapon DefaultWeapon { get; set; }

        public Character(string name, int health, int strength, int protection)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Protection = protection;
            DefaultWeapon = new Hand();
            Weapon = DefaultWeapon;
        }
    }
}
