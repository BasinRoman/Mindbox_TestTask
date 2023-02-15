namespace FigureArea.Figures
{
    public class Circle : AbstractFigure
    {
        public double radius { get;}

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException( "Радиус не может быть равен или меньше нуля" );
            }

            this.radius = radius;
        }
        public override double GetArea() //переопределим абстрактный метод
        {
            return double.Pi*Math.Pow(radius, 2);
        }        
    }
}