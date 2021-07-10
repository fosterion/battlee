using Battlee.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Shared.Models.Base
{
    class Enemy
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public Element Element { get; set; }
    }
}
