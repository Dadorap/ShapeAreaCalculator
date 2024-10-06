using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double _width, double _length)
        {
            Width = _width;
            Length = _length;
        }

        public override double CalcArea()
        {
            double area = Length * Width;
            return area;
        }

    }
}
