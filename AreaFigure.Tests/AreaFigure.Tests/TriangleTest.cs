using Area.Model.Figure;

namespace AreaFigure.Tests;

public class TriangleTest
{
    private Triangle triangleWrong;
    private Triangle triangleRight;
    private Triangle triangleError;


    [SetUp]
    public void Setup()
    {
        triangleWrong = new Triangle(12, 23, 23);
        triangleRight = new Triangle(3, 4, 5);
        triangleError = new Triangle(0, 0, 0);
    }

    [Test]
    public void TestGetArea()
    {
        Assert.That(triangleRight.GetArea(), Is.EqualTo(6));
        Assert.That(triangleWrong.GetArea(), Is.EqualTo(133).Within(1));
    }

    [Test]
    public void TestRightTriangle()
    {
        Assert.That(triangleRight.IsRight(), Is.EqualTo(true));
    }

    [Test]
    public void TestWrongTriangle()
    {
        Assert.That(triangleWrong.IsRight(), Is.EqualTo(false));
    }

    [Test]
    public void TestErrorTriangle()
    {
        Assert.Throws<DivideByZeroException>(() => triangleError.IsRight());
    }
}