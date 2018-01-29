using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_GameWorldLibrary
{
    public class Coords
    {
        public int X;
        public int Y;
        public int Z;

        //CONSTRUCTORS:
        public Coords()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Coords(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Coords(Coords c)
        {
            X = c.X;
            Y = c.Y;
            Z = c.Z;
        }

        //OVERLOADING:
        public static Coords operator +(Coords c1, Coords c2)//  +
        {
            return new Coords(c1.X + c2.X, c1.Y + c2.Y, c1.Z + c2.Z);
        }
        public static Coords operator -(Coords c1, Coords c2)//  +
        {
            return new Coords(c1.X - c2.X, c1.Y - c2.Y, c1.Z - c2.Z);
        }
        public static Coords operator *(Coords c, int m)//    *
        {
            return new Coords(c.X * m, c.Y * m, c.Z * m);
        }
        public static Coords operator /(Coords c, int d)//    /
        {
            return new Coords(c.X / d, c.Y / d, c.Z / d);
        }
        public static bool operator ==(Coords c1, Coords c2)//    ==
        {
            return (c1.X == c2.X && c1.Y == c2.Y && c1.Z == c2.Z);
        }
        public static bool operator !=(Coords c1, Coords c2)//    !=
        {
            return !(c1.X == c2.X && c1.Y == c2.Y && c1.Z == c2.Z);
        }
    }
}
