using System;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        abstract public double Area { get; }
    }
}
