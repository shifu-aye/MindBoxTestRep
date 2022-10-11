using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Area
    {
        public double Pi = 3.14;
        public double Radius { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double CircleАrea(double radius)
        {
            Radius = radius;
            double area = Pi * Math.Pow(radius, 2);
            return area;
        }
        public double TriangleАrea(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            double HalfPerimetr = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(HalfPerimetr * (HalfPerimetr - side1) * (HalfPerimetr - side2) * HalfPerimetr - side3);
            
            return area;
        }
        public string isRectangularTriangle(double side1, double side2, double side3)
        {
            string isRectangularTriangle;
            if (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2))
            {
                isRectangularTriangle = "Треугольник прямоугольный";
            }
            else
            {
                isRectangularTriangle = "Треугольник не прямоугольный";
            }
            return isRectangularTriangle;
        }
    }
}
