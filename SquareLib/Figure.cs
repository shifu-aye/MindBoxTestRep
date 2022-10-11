using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public abstract class Figure
    {
        public string NameFigure { get; set; }
        public abstract double Area();
    }
}
