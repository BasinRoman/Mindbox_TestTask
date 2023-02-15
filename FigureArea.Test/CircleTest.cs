using FigureArea.Figures;

namespace FigureArea.Test;

public class CircleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Circle_Area_Math()
    {
        double radius = 2.0;
        var circle = new Circle(radius);
        double result = circle.GetArea();
        Assert.AreEqual(12.566370614359172d, result);
    }
   
    [Test]
    public void Test_Circle_RadiusIs0_Await_ArgumentExeption()
    {
        double radius = 0;
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}