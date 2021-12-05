namespace Shapes;
public abstract class Shape : IShape
{
    abstract public double Area { get; }

    abstract public ushort Corners { get; }
    public string Name { get; }

    public Shape()
    {
        this.Name = this.GetType().ToString();
    }
}
