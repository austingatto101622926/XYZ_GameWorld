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

            WriteRelativeDirections(Orient);
            Orient.TurnClockwiseAsIfFacing(Orient.Bearing[Orientation.RelativeDir.Left], -2);
            WriteRelativeDirections(Orient);

            Console.ReadLine();
        }

        public static void WriteRelativeDirections(Orientation orientation)
        {
            Console.WriteLine("Foward: {0}, Right: {1}, Back: {2}, Left: {3}"
                , orientation.Bearing[Orientation.RelativeDir.Foward]
                , orientation.Bearing[Orientation.RelativeDir.Right]
                , orientation.Bearing[Orientation.RelativeDir.Back]
                , orientation.Bearing[Orientation.RelativeDir.Left]
            );
        }
    }
}
