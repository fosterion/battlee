using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.Monsters
{
    class HellDog : IMonster
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Damage { get; set; }

        public HellDog(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }
}
