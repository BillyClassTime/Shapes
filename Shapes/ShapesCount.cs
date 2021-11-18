using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public static class ShapesCount
    {
        public static double Count (this IShape Shape, ShapeMoodValue mood)
        {
            const int TRIPLE = 3;
            const int DOUBLE = 2;
            double count = default;
            switch (mood)
            {
                case ShapeMoodValue.Normal:
                    count = Shape.Area + Shape.Corners;
                    break;
                case ShapeMoodValue.Happy:
                    count = Shape.Area * DOUBLE + Shape.Corners * DOUBLE; 
                    break;
                case ShapeMoodValue.SupperHappy:
                    count = Shape.Area * TRIPLE + Shape.Corners * TRIPLE;
                    break;
            }
            return count;
        }
    }
}
