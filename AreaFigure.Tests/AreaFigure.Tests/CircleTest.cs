using Area.Model.Figure;

namespace AreaFigure.Tests;

public class CircleTest
{
    private Circle circle;
    

    [SetUp]
    public void Setup()
    {
        circle = new Circle(4);
      
    }

    [Test]
    public void TestGetArea()
    {
        Assert.That(circle.GetArea(), Is.EqualTo(50).Within(1));
    }

}