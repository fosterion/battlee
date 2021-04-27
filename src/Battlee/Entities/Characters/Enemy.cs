using Battlee.Enums;
using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.Characters
{
    class Enemy : IEnemy
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public Element Element { get; set; }

        public Enemy(string name, int health, int minDamage, int maxDamage, Element element)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Element = element;
        }
    }
}
