namespace Figure_area.Figures
{
    public class Circle : AbstractFigure
    {
        public double radius { get; set; }
        public override double GetArea() //переопределим абстрактный метод
        {
            return double.Pi*Math.Pow(radius, 2);
        }        
    }
}