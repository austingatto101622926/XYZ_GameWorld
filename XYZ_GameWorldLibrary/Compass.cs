using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_GameWorldLibrary
{
    public static class Compass
    {
        public enum Direction
        {
            North,
            East,
            South,
            West,
            Up,
            Down
        };

        public static Dictionary<Direction, Coords> Coords = new Dictionary<Direction, Coords>
        {
            { Direction.North, new Coords(0,-1,0) },
            { Direction.East,  new Coords(+1,0,0) },
            { Direction.South, new Coords(0,+1,0) },
            { Direction.West,  new Coords(-1,0,0) },
            { Direction.Up,    new Coords(0,0,+1) },
            { Direction.Down,  new Coords(0,0,-1) }
        };
    }
}
