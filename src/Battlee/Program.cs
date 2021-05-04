using Battlee.Interfaces;
using Battlee.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Battlee.Enums;
using System.Threading.Tasks;
using System.Threading;
using Battlee.Mechanics;

namespace Battlee
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

            ic.CommonItem   ("Common:    " + rar.Count(x => x is Rarity.Common));
            ic.UncommonItem ("Uncommon:  " + rar.Count(x => x is Rarity.Uncommon));
            ic.RareItem     ("Rare:      " + rar.Count(x => x is Rarity.Rare));
            ic.EpicItem     ("Epic:      " + rar.Count(x => x is Rarity.Epic));
            ic.LegendaryItem("Legendary: " + rar.Count(x => x is Rarity.Legendary));

            Console.ReadKey();
        }

        private static Element RollElement(bool isAlwaysElement = false)
        {
            var beginRnd = isAlwaysElement ? 61 : 1;

            return new Random().Next(beginRnd, 100) switch
            {
                int n when (n <= 60)           => Element.None,
                int n when (n > 60 && n <= 70) => Element.Fire,
                int n when (n > 70 && n <= 80) => Element.Ice,
                int n when (n > 80 && n <= 90) => Element.Electric,
                int n when (n > 90)            => Element.Earth,
                _ => throw new InvalidOperationException("Unknown element")
            };
        }
    }
}
