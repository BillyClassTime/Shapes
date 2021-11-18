using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        public double Circumference { get => 2 * 3.14159 * Radius; }
        public double Area { get => 3.14159 * (Radius * Radius); }
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
