using FigureArea.Figures;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(firstFacet: 3, secondFacet: 7, thirdFacet: 8);
            var circle = new Circle(radius: 2);
            
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.ifRight());
            
        }
    }
}


