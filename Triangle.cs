using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double _base, double _hight)
        {
            Base = _base;
            Height = _hight;
        }

        public override double CalcArea()
        {
            double area = 0.5 * Height * Base;
            return area;
        }
    }
}
