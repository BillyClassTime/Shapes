using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IShape
    {
        public double Perimeter { get => Height + Width + (Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2))); }
        public double Area { get => 0.5 * Height * Width; }
        private double Width { get; set; }
        private double Height { get; set; }

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
