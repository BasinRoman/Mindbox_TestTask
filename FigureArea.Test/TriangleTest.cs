using FigureArea.Figures;

namespace FigureArea.Test;

public class TriangleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Triangle_Area_Math()
    {
        double firstFacet = 3;
        double secondFacet = 7;
        double thirdFacet = 8;
        var triangle = new Triangle(firstFacet, secondFacet, thirdFacet);
        double result = triangle.GetArea();
        Assert.AreEqual(10.392304845413264, result);
    }
   
    [Test]
    public void Test_Triangle_AnyFacetIsZero_Await_ArgumentExeption()
    {
        double firstFacet = 0;
        double secondFacet = 2;
        double thirdFacet = 3;
        Assert.Throws<ArgumentException>(() => new Triangle(firstFacet, secondFacet, thirdFacet));
    }

    [Test]
    public void Test_Triangle_SumOfTwoFacetsLessThatThird()
    {
        double firstFacet = 2;
        double secondFacet = 4;
        double thirdFacet = 8;
        Assert.Throws<ArgumentException>(() => new Triangle(firstFacet, secondFacet, thirdFacet));
    }
}