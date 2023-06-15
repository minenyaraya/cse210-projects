public class Rectangle: Shape
{
    private double _lenght;
    private double _widht;
    public Rectangle(string color, double lenght, double widht): base(color)
    {
        _lenght = lenght;
        _widht = widht;
    }
    public override double GetArea()
    {
        return _widht * _lenght;
    }
}    