using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaShapesLib;
using System;

namespace AreaShapesLibTests
{
    [TestClass]
    public class AreaShapesLibTests
    {
        AreaShapes areaShapes;

        [TestInitialize]
        public void TestInitialize()
        {
            areaShapes = new AreaShapes();
        }

        [TestMethod]
        public void ÑircleArea_8_20106returned()
        {
            // arrange
            double radius = 8;
            double expected = 201.06;

            // act
            double actual = areaShapes.ÑircleArea(radius);
            actual = Math.Round(actual, 2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ÑircleArea_8_10NotReturned()
        {
            // arrange
            double radius = 8;
            double notExpected = 10;

            // act
            double actual = areaShapes.ÑircleArea(radius);
            actual = Math.Round(actual, 2);

            // assert
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void TriangleArea_4_5_6_992returned()
        {
            // arrange
            double a = 4;
            double b = 5;
            double c = 6;
            double expected = 9.92;

            // act
            double actual = areaShapes.TriangleArea(a, b, c);
            actual = Math.Round(actual, 2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_4_5_6_10NotReturned()
        {
            // arrange
            double a = 4;
            double b = 5;
            double c = 6;
            double notExpected = 10;

            // act
            double actual = areaShapes.TriangleArea(a, b, c);
            actual = Math.Round(actual, 2);

            // assert
            Assert.AreNotEqual(notExpected, actual);
        }
    }
}
