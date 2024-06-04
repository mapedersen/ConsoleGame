using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleg.ConsoleGame.UserInterface
{
    internal class ConsoleUI
    {
        internal static ConsoleKey GetKey() => Console.ReadKey(true).Key;
    }
}
