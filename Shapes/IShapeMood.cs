using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    interface IShapeMood
    {
        public ShapeMoodValue ShapeMood { get; set; }
        public double Count { get; }
    }
}
