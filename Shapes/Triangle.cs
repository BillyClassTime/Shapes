using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double Perimeter { get => Height + Width + (Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2))); }
        public override double Area { get => 0.5 * Height * Width; }
        private double Width { get; set; }
        private double Height { get; set; }
        const ushort THREE = 3;
        public override ushort Corners => THREE;

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
