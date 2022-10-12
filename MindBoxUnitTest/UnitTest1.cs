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
            // assert
            Assert.AreEqual(2827.35, new Circle(30).Area());
        }

        [TestMethod]
        public void TriangleArea_Side1_12_Side2_3_Side3_4()
        {
            // assert
            Assert.AreEqual(0, new Triangle(12,3,4).Area());
        }

        [TestMethod]
        public void IsRectangularTriangle_Side1_3_Side2_4_Side3_5()
        {
            // assert
            Assert.AreEqual("Прямоугольный треугольник", new Triangle(3,4,5).IsRectangularTriangle());
        }

        [TestMethod]
        public void IsRectangularTriangle_Side1_2_Side2_4_Side3_3()
        {
            Assert.AreEqual("НЕ прямоугольный треугольник", new Triangle(2, 4, 3).IsRectangularTriangle());
        }
    }
}
