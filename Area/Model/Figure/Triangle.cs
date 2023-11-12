namespace Area.Model.Figure;

public class Triangle : Core.Figure
{
    private int firstSide, secondSide, thirdSide;

    private int Sum => firstSide+secondSide+thirdSide;
    
    /// <param name="firstSide">value > 0</param>
    /// <param name="secondSide">value > 0</param>
    /// <param name="thirdSide">value > 0</param>
    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public override double GetArea()
    {
        float halfSum = Sum / 2;
        return Math.Sqrt(halfSum * (halfSum - firstSide) * (halfSum - secondSide) * (halfSum - thirdSide));
    }

    public bool IsRight()
    {
        int max = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
        
        return max * max ==( Math.Pow(Sum - max, 2) - 2 * (firstSide*secondSide*thirdSide/ max)); //Пока нет валидации на 0 и в целом на возможность существования треугольника будет выдавать ошибку
    }
}