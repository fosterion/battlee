using Battlee.Enums;
using Battlee.Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battlee.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var ic = new ItemColor();
            var roll = new RarityRoll();
            var rar = new List<Rarity>();

            for (int i = 0; i < 10000; i++)
            {
                var randomed = roll.Get(1.1);
                rar.Add(randomed);
            }

            ic.CommonItem("Common:    " + rar.Count(x => x is Rarity.Common));
            ic.UncommonItem("Uncommon:  " + rar.Count(x => x is Rarity.Uncommon));
            ic.RareItem("Rare:      " + rar.Count(x => x is Rarity.Rare));
            ic.EpicItem("Epic:      " + rar.Count(x => x is Rarity.Epic));
            ic.LegendaryItem("Legendary: " + rar.Count(x => x is Rarity.Legendary));

            Console.ReadKey();
        }
    }
}
