namespace Area.Model.Figure;

public class Circle : Core.Figure
{
    private int radius;

/// <param name="radius">value > 0</param>
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}