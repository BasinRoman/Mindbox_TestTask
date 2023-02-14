using Figure_area.Figures;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle= new Circle { radius = 2};
            Triangle triangle = new(1,2,3);
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.ifRight());
            Console.ReadLine();
        }
    }
}


