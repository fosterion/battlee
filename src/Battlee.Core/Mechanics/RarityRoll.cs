using Battlee.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battlee.Mechanics
{
    class RarityRoll
    {
        private const int BaseCommon    = 50;
        private const int BaseUncommon  = 25;
        private const int BaseRare      = 15;
        private const int BaseEpic      = 8;
        private const int BaseLegendary = 2;

        internal Rarity Get(double coeff = 1.0)
        {
            if (coeff < 0.0) coeff = 0.0;
            if (coeff > 2.0) coeff = 2.0;

            var common    = BaseCommon    * (2 - coeff);
            var uncommon  = BaseUncommon  * coeff + common;
            var rare      = BaseRare      * coeff + uncommon;
            var epic      = BaseEpic      * coeff + rare;
            var legendary = BaseLegendary * coeff + epic;

            return new Random().Next(1, 100) switch
            {
                int n when (n <= common)                 => Rarity.Common,
                int n when (n > common && n <= uncommon) => Rarity.Uncommon,
                int n when (n > uncommon && n <= rare)   => Rarity.Rare,
                int n when (n > rare && n <= epic)       => Rarity.Epic,
                int n when (n > epic && n <= legendary)  => Rarity.Legendary,
                _ => throw new InvalidOperationException("Unknown rarity")
            };
        }
    }
}
