using Battlee.Interfaces;
using Battlee.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Battlee.Enums;
using System.Threading.Tasks;
using System.Threading;

namespace Battlee
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Rarity>();

            for (int i = 0; i < 10000; i++)
            {
                var randomed = RollRarity(Rarity.Uncommon);
                items.Add(randomed);
            }

            Console.WriteLine("Common:\t\t"  + items.Count(x => (int)x == 1));
            Console.WriteLine("Uncommon:\t"  + items.Count(x => (int)x == 50));
            Console.WriteLine("Rare:\t\t"    + items.Count(x => (int)x == 75));
            Console.WriteLine("Epic:\t\t"    + items.Count(x => (int)x == 90));
            Console.WriteLine("Legendary:\t" + items.Count(x => (int)x == 98));

            Console.ReadKey();
        }

        private static Rarity RollRarity(Rarity beginRarity)
        {
            return new Random().Next((int)beginRarity + 1, 100) switch
            {
                int n when (n <= 50)           => Rarity.Common,
                int n when (n > 50 && n <= 75) => Rarity.Uncommon,
                int n when (n > 75 && n <= 90) => Rarity.Rare,
                int n when (n > 90 && n <= 98) => Rarity.Epic,
                int n when (n > 98)            => Rarity.Legendary,
                _ => throw new NotImplementedException("Unknown rarity")
            };
        }
    }
}
