using Battlee.Enums;
using Battlee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Entities.Enemies
{
    class Troll : IEnemy
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }

        public Element Element { get; set; }

        public Troll(string name, int health, double damage, Element element)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Element = element;
        }
    }
}
