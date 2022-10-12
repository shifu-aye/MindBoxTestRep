using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Triangle : Figure<double>
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;
        public Triangle()
        {

        }
        /// <summary>
        /// Конструктор инициализации класса "Треугольник"
        /// </summary>
        /// <param name="side1">Первая сторона</param>
        /// <param name="side2">Вторая сторона</param>
        /// <param name="side3">Третья сторона</param>
        public Triangle(double side1, double side2, double side3)
        {
            NameFigure = "Треугольник";
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Возвращает площадь треугольника</returns>
        public override double Area()
        {
            return (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2) ? Math.Round((Math.Sqrt((side1 + side2 + side3) / 2 * ((side1 + side2 + side3) / 2 - side1) * ((side1 + side2 + side3) / 2 - side2) * (side1 + side2 + side3) / 2 - side3)),2) : 0.0;
        }
        /// <summary>
        /// Определение прямоугольности треугольника
        /// </summary>
        /// <returns>Возвращает прямоугольный треугольник или нет</returns>
        public string IsRectangularTriangle()
        {
            return (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) && Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2) && Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side3, 2)) ? "Прямоугольный треугольник" : "НЕ прямоугольный треугольник";
        }
    }
}
