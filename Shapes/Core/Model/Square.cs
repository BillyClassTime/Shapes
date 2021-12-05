public class Square : Shape
{

    public double Perimeter { get => 2 * (Length + Height); }
    public override double Area { get => Length * Height; }
    private double length;
    private double height;

    public double Height
    {
        get { return height; }
        set
        {
            if (length != 0)
            {
                if (length == value) height = length;
                else throw new ArgumentException("The lengh must be same to height");
            }
            else
            {
                length = value;
                height = value;
            }
        }
    }

    public double Length
    {
        get { return length; }
        set
        {
            if (height != 0)
            {
                if (height == value) length = height;
                else throw new ArgumentException("The lengh must be same to height");
            }
            else height = length = value;
        }
    }

    const ushort FOUR = 4;
    public override ushort Corners => FOUR;

    public Square(double length, double height)
    {
        if (length != height)
            throw new ArgumentException("The lengh must be same to height");
        Height = height;
        Length = length;
    }
    public Square() { }
}
