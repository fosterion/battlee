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

            Console.WriteLine("==========");

            var elements = new List<Element>();
            for (int i = 0; i < 10000; i++)
            {
                var randomed = RollElement(true);
                elements.Add(randomed);
            }
            Console.WriteLine("None:\t\t"   + elements.Count(x => (int)x == 1));
            Console.WriteLine("Fire:\t\t"   + elements.Count(x => (int)x == 60));
            Console.WriteLine("Ice:\t\t"    + elements.Count(x => (int)x == 70));
            Console.WriteLine("Electric:\t" + elements.Count(x => (int)x == 80));
            Console.WriteLine("Earth:\t\t"  + elements.Count(x => (int)x == 90));

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
                _ => throw new NotImplementedException("Unknown element")
            };
        }
    }
}
