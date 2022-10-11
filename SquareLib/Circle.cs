using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public const double Pi = 3.1415;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Circle()
        {

        }
        /// <summary>
        /// Конструктор класса "Окружность"
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            Radius = radius;
            NameFigure = "Окружность";
        }
        /// <summary>
        /// Вычисление площади окружности
        /// </summary>
        /// <returns>Возвращается площадь окружности</returns>
        public override double Area()
        {
            return Math.Round((Pi * Radius * Radius),2);
        }
    }
}
