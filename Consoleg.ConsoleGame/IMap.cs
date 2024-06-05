using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleg.ConsoleGame
{
    internal interface IMap
    {
        List<Creature> Creatures { get; }
        int Height { get; }
        int Width { get; }

        Cell? GetCell(int y, int x);
        Cell? GetCell(Position newPosition);
    }
}
