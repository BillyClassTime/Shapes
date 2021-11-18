using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : IShape
    {

        public double Perimeter { get => 2 * (Length + Height); }
        public double Area { get => Length * Height; }
        private double Length { get; set; }
        private double Height { get; set; }

        public Square(double length, double height)
        {
            Height = height;
            Length = length;
        }

    }
}
