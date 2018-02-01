using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XYZ_GameWorldLibrary;

namespace XYZ_GameWorldUnitTests
{
    [TestClass]
    public class Orientation3DTurns
    {
        [TestMethod]
        public void PositiveNorth()
        {
            //Arrange
            Orientation orientation = new Orientation();

            //Act
            orientation.RotateClockwiseFacing(Compass.Direction.North, 1);

            Compass.Direction Foward = orientation.Facing[Orientation.RelativeDir.Foward];
            Compass.Direction Right = orientation.Facing[Orientation.RelativeDir.Right];
            Compass.Direction Back = orientation.Facing[Orientation.RelativeDir.Back];
            Compass.Direction Left = orientation.Facing[Orientation.RelativeDir.Left];
            Compass.Direction Above = orientation.Facing[Orientation.RelativeDir.Above];
            Compass.Direction Below = orientation.Facing[Orientation.RelativeDir.Below];

            //Assert

            Assert.AreEqual(Foward, Compass.Direction.North);
            Assert.AreEqual(Right, Compass.Direction.Down);
            Assert.AreEqual(Back, Compass.Direction.South);
            Assert.AreEqual(Left, Compass.Direction.Up);
            Assert.AreEqual(Above, Compass.Direction.East);
            Assert.AreEqual(Below, Compass.Direction.West);
        }
        [TestMethod]
        public void PositiveEast()
        {
            //Arrange
            Orientation orientation = new Orientation();

            //Act
            orientation.RotateClockwiseFacing(Compass.Direction.East, 1);

            Compass.Direction Foward = orientation.Facing[Orientation.RelativeDir.Foward];
            Compass.Direction Right = orientation.Facing[Orientation.RelativeDir.Right];
            Compass.Direction Back = orientation.Facing[Orientation.RelativeDir.Back];
            Compass.Direction Left = orientation.Facing[Orientation.RelativeDir.Left];
            Compass.Direction Above = orientation.Facing[Orientation.RelativeDir.Above];
            Compass.Direction Below = orientation.Facing[Orientation.RelativeDir.Below];

            //Assert

            Assert.AreEqual(Foward, Compass.Direction.Up);
            Assert.AreEqual(Right, Compass.Direction.East);
            Assert.AreEqual(Back, Compass.Direction.Down);
            Assert.AreEqual(Left, Compass.Direction.West);
            Assert.AreEqual(Above, Compass.Direction.South);
            Assert.AreEqual(Below, Compass.Direction.North);
        }
        [TestMethod]
        public void PositiveSouth()
        {
            //Arrange
            Orientation orientation = new Orientation();

            //Act
            orientation.RotateClockwiseFacing(Compass.Direction.South, 1);

            Compass.Direction Foward = orientation.Facing[Orientation.RelativeDir.Foward];
            Compass.Direction Right = orientation.Facing[Orientation.RelativeDir.Right];
            Compass.Direction Back = orientation.Facing[Orientation.RelativeDir.Back];
            Compass.Direction Left = orientation.Facing[Orientation.RelativeDir.Left];
            Compass.Direction Above = orientation.Facing[Orientation.RelativeDir.Above];
            Compass.Direction Below = orientation.Facing[Orientation.RelativeDir.Below];

            //Assert

            Assert.AreEqual(Foward, Compass.Direction.North);
            Assert.AreEqual(Right, Compass.Direction.Up);
            Assert.AreEqual(Back, Compass.Direction.South);
            Assert.AreEqual(Left, Compass.Direction.Down);
            Assert.AreEqual(Above, Compass.Direction.West);
            Assert.AreEqual(Below, Compass.Direction.East);
        }
        [TestMethod]
        public void PositiveWest()
        {
            //Arrange
            Orientation orientation = new Orientation();

            //Act
            orientation.RotateClockwiseFacing(Compass.Direction.West, 1);

            Compass.Direction Foward = orientation.Facing[Orientation.RelativeDir.Foward];
            Compass.Direction Right = orientation.Facing[Orientation.RelativeDir.Right];
            Compass.Direction Back = orientation.Facing[Orientation.RelativeDir.Back];
            Compass.Direction Left = orientation.Facing[Orientation.RelativeDir.Left];
            Compass.Direction Above = orientation.Facing[Orientation.RelativeDir.Above];
            Compass.Direction Below = orientation.Facing[Orientation.RelativeDir.Below];

            //Assert

            Assert.AreEqual(Foward, Compass.Direction.Down);
            Assert.AreEqual(Right, Compass.Direction.East);
            Assert.AreEqual(Back, Compass.Direction.Up);
            Assert.AreEqual(Left, Compass.Direction.West);
            Assert.AreEqual(Above, Compass.Direction.North);
            Assert.AreEqual(Below, Compass.Direction.South);
        }
        [TestMethod]
        public void PositiveUp()
        {
            //Arrange
            Orientation orientation = new Orientation();

            //Act
            orientation.RotateClockwiseFacing(Compass.Direction.Up, 1);

            Compass.Direction Foward = orientation.Facing[Orientation.RelativeDir.Foward];
            Compass.Direction Right = orientation.Facing[Orientation.RelativeDir.Right];
            Compass.Direction Back = orientation.Facing[Orientation.RelativeDir.Back];
            Compass.Direction Left = orientation.Facing[Orientation.RelativeDir.Left];
            Compass.Direction Above = orientation.Facing[Orientation.RelativeDir.Above];
            Compass.Direction Below = orientation.Facing[Orientation.RelativeDir.Below];

            //Assert

            Assert.AreEqual(Foward, Compass.Direction.West);
            Assert.AreEqual(Right, Compass.Direction.North);
            Assert.AreEqual(Back, Compass.Direction.East);
            Assert.AreEqual(Left, Compass.Direction.South);
            Assert.AreEqual(Above, Compass.Direction.Up);
            Assert.AreEqual(Below, Compass.Direction.Down);
        }
        [TestMethod]
        public void PositiveDown()
        {
            //Arrange
            Orientation orientation = new Orientation();

            //Act
            orientation.RotateClockwiseFacing(Compass.Direction.Down, 1);

            Compass.Direction Foward = orientation.Facing[Orientation.RelativeDir.Foward];
            Compass.Direction Right = orientation.Facing[Orientation.RelativeDir.Right];
            Compass.Direction Back = orientation.Facing[Orientation.RelativeDir.Back];
            Compass.Direction Left = orientation.Facing[Orientation.RelativeDir.Left];
            Compass.Direction Above = orientation.Facing[Orientation.RelativeDir.Above];
            Compass.Direction Below = orientation.Facing[Orientation.RelativeDir.Below];

            //Assert

            Assert.AreEqual(Foward, Compass.Direction.East);
            Assert.AreEqual(Right, Compass.Direction.South);
            Assert.AreEqual(Back, Compass.Direction.West);
            Assert.AreEqual(Left, Compass.Direction.North);
            Assert.AreEqual(Above, Compass.Direction.Up);
            Assert.AreEqual(Below, Compass.Direction.Down);
        }
    }
}
