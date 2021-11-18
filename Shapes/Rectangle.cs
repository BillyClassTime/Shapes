using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IShape
    {
        public double Perimeter { get => 2 * (Length + Height); }
        public double Area { get => Length * Height; }
        private double Length { get; set; }
        private double Height { get; set; }
        const ushort FOUR = 4;
        public ushort Corners => FOUR;


        public Rectangle(double length, double height)
        {
            Height = height;
            Length = length;
        }

    }
}


