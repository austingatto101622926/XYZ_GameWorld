using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_GameWorldLibrary
{
    public class Orientation
    {
        public enum RelativeDir
        {
            Foward,
            Right,
            Back,
            Left,
            Above,
            Below
        };

        public Dictionary<RelativeDir, Compass.Direction> Facing { get; private set; } = new Dictionary<RelativeDir, Compass.Direction>
        {
            { RelativeDir.Foward, Compass.Direction.North },
            { RelativeDir.Right,  Compass.Direction.East },
            { RelativeDir.Back,   Compass.Direction.South },
            { RelativeDir.Left,   Compass.Direction.West },
            { RelativeDir.Above,  Compass.Direction.Up },
            { RelativeDir.Below,  Compass.Direction.Down },
        };

        public void RotateClockwiseFacing(Compass.Direction facing, int quarterCount = 1)
        {
            //Array of the directions that will be cycled
            Compass.Direction[] Dir = new Compass.Direction[4];
            //Determine which direction are cycled depending on a perspective direction
            switch (facing)
            {
                case Compass.Direction.North:
                    Dir[0] = Compass.Direction.Up;
                    Dir[1] = Compass.Direction.East;
                    Dir[2] = Compass.Direction.Down;
                    Dir[3] = Compass.Direction.West;
                    break;
                case Compass.Direction.East:
                    Dir[0] = Compass.Direction.Up;
                    Dir[1] = Compass.Direction.South;
                    Dir[2] = Compass.Direction.Down;
                    Dir[3] = Compass.Direction.North;
                    break;
                case Compass.Direction.South:
                    Dir[0] = Compass.Direction.Up;
                    Dir[1] = Compass.Direction.West;
                    Dir[2] = Compass.Direction.Down;
                    Dir[3] = Compass.Direction.East;
                    break;
                case Compass.Direction.West:
                    Dir[0] = Compass.Direction.Up;
                    Dir[1] = Compass.Direction.North;
                    Dir[2] = Compass.Direction.Down;
                    Dir[3] = Compass.Direction.South;
                    break;
                case Compass.Direction.Up:
                    Dir[0] = Compass.Direction.South;
                    Dir[1] = Compass.Direction.East;
                    Dir[2] = Compass.Direction.North;
                    Dir[3] = Compass.Direction.West;
                    break;
                case Compass.Direction.Down:
                    Dir[0] = Compass.Direction.North;
                    Dir[1] = Compass.Direction.East;
                    Dir[2] = Compass.Direction.South;
                    Dir[3] = Compass.Direction.West;
                    break;
            }
            //Store the current indexes of the changing directions
            int[] vIndex = new int[]
            {
                Facing.Values.ToList().IndexOf(Dir[0]),
                Facing.Values.ToList().IndexOf(Dir[1]),
                Facing.Values.ToList().IndexOf(Dir[2]),
                Facing.Values.ToList().IndexOf(Dir[3])
            };
            //Handle quarterCounts greater than 4
            quarterCount = quarterCount % 4;
            for (int i = 0; i < 4; i++)
            {
                //determine the new direction of direction i
                int newDir = i + quarterCount;
                if (newDir >= 4) newDir -= 4;
                if (newDir <= -1) newDir += 4;
                //change the dictionary value from its current direction to its new direction
                Facing[(RelativeDir)vIndex[i]] = Dir[newDir];
            }
        }
    }
}
