using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Shared.Models.Base
{
    class Protagonist
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public int Protection { get; set; }

        public Weapon Weapon { get; set; }
    }
}
