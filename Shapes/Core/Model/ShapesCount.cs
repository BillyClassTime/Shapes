public static class ShapesCount
{
    public static double Count(this Shape shape, ShapeMoodValue mood)
    {
        const int TRIPLE = 3;
        const int DOUBLE = 2;
        const ushort TEN_CORNERS = 10;
        const ushort FIVE_CORNERS = 5;
        double count = default;
        switch (mood)
        {
            case ShapeMoodValue.Normal:
                count = shape.Area + shape.Corners;
                break;
            case ShapeMoodValue.Happy:
                if (shape.GetType() == typeof(Circle))
                    count = shape.Area * DOUBLE + FIVE_CORNERS * DOUBLE;
                else
                    count = shape.Area * DOUBLE + shape.Corners * DOUBLE;
                break;
            case ShapeMoodValue.SuperHappy:
                if (shape.GetType() == typeof(Circle))
                    count = shape.Area * TRIPLE + TEN_CORNERS * TRIPLE;
                else
                    count = shape.Area * TRIPLE + shape.Corners * TRIPLE;
                break;
        }
        return count;
    }
}
