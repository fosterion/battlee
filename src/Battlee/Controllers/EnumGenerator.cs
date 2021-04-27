using Battlee.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battlee.Controllers
{
    class EnumGenerator
    {
        internal static T GetRandom<T>()
        {
            var values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(new Random().Next(values.Length));
        }
    }
}
