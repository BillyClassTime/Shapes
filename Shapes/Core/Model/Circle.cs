public class Circle : Shape
{
    public double Circumference { get => 2 * 3.14159 * Radius; }
    public override double Area { get => 3.14159 * (Radius * Radius); }
    public double Radius { get; set; }
    const ushort ZERO = 0;
    public override ushort Corners => ZERO;

    public Circle(double radius)
    {
        Radius = radius;
    }
    public Circle() { }
}

