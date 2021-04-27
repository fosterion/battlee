using Battlee.Entities.Monsters;
using Battlee.Entities.PlayerRaces;
using Battlee.Entities.Weapons;
using Battlee.Interfaces;
using Battlee.Managers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battlee
{
    class Program
    {
        private static Battle bm;

        static void Main(string[] args)
        {
            bm = new Battle();
            var player = CreateCharacter();
            var monsters = CreateMonsters();
            var weapons = CreateWeapons();

            Console.WriteLine($"{player.Name} держит в руках {player.Weapon.Name}");

            bm.Hit(player, monsters[0]);

            player.Weapon = weapons.First();

            Console.WriteLine($"{player.Name} держит в руках {player.Weapon.Name}");

            bm.Hit(player, monsters[0]);

            player.Weapon = weapons.Last();

            Console.WriteLine($"{player.Name} держит в руках {player.Weapon.Name}");

            bm.Hit(player, monsters[0]);

            Console.ReadKey();
        }

        private static IPlayer CreateCharacter()
        {
            return new Human("Леонард", 100, 5, 10, new Hand());
        }

        private static List<IMonster> CreateMonsters()
        {
            return new List<IMonster>
            {
                new HellDog("Неистовый адский пёс", 1000, 37),
                new IceTroll("Ледяной тролль Валентин", 2400, 49)
            };
        }

        private static List<IWeapon> CreateWeapons()
        {
            return new List<IWeapon>
            {
                new BrokenSword("Сломанный железный меч", 4, 7),
                new FlameHammer("Пламенный молот вождя", 66, 14)
            };
        }
    }
}
