using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_GameWorldLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Orientation Orient = new Orientation();

            Orient.TurnClockwiseAsIfFacing(Compass.Direction.Down, 2);
            WriteRelativeDirections(Orient);

            Console.ReadLine();
        }

        public static void WriteRelativeDirections(Orientation orientation)
        {
            Console.WriteLine("Foward: {0}, Right: {1}, Back: {2}, Left: {3}"
                , orientation.Facing[Orientation.RelativeDir.Foward]
                , orientation.Facing[Orientation.RelativeDir.Right]
                , orientation.Facing[Orientation.RelativeDir.Back]
                , orientation.Facing[Orientation.RelativeDir.Left]
            );
        }
    }
}
