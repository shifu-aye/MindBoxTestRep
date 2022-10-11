using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SquareLib;

namespace MindBoxUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleArea_Radius_30()
        {
            // arrange
            double expected = 2827.35;
            // act
            double result = new Circle(30).Area();
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleArea_Side1_12_Side2_3_Side3_4()
        {
            // assert
            Assert.AreEqual(0, new Triangle(12,3,4).Area());
        }
    }
}
