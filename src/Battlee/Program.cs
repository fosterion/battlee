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
        private static BattleController bc;

        static void Main(string[] args)
        {
            bc = new BattleController();

            Console.ReadKey();
        }
    }
}
