﻿using System;

namespace Shapes
{
    public interface IShape
    {
        double Area { get; }
        ushort Corners { get; }
    }
}