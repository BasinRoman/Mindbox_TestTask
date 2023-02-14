using System.ComponentModel.DataAnnotations;

namespace Figure_area.Figures
{
    public class Triangle: AbstractFigure
    {
        public double firstFacet { get; set; }
        public double secondFacet { get; set; }
        public double thirdFacet { get; set; }
        readonly double[] SidesArray;
        
        
        // Я положил валидацию данных в конструктор, однако на крупных проектах так делать не стоит.
        // Память под объект будет выделена даже если мы словим ошибку. Получим потенциальный memory leak. 
        // Я бы обыграл это через статический класс-валидатор, перед созданием обхекта. Но тогда мы заставим пользователя создавать треугольник как-то так Validator.TryCreate(*,*,*)..
        public Triangle(double firstFacet, double secondFacet, double thirdFacet)
        {
            if (firstFacet <= 0 || secondFacet <= 0 || thirdFacet <= 0)
                throw new ArgumentException("Стороны треугольника не должны быть меньше или равны нулю!");
            else if (firstFacet + secondFacet < thirdFacet || secondFacet + thirdFacet < firstFacet || firstFacet + thirdFacet < secondFacet)
                throw new ArgumentException("Сумма двух сторон треугольника не должна быть равна или меньше третьей стороны!");
            SidesArray = new double[] { firstFacet, secondFacet, thirdFacet };
        }

        public override double GetArea()
        {
            double p = (firstFacet + secondFacet + thirdFacet)/2;
            return Math.Sqrt(p * (p - firstFacet) * (p - secondFacet) * (p - thirdFacet));
        }

        //Проверка sqrt гипотенузы == сумме sqrt`s двух катетов
        public bool ifRight()
        {
            Array.Sort(SidesArray);
            if (Math.Pow(SidesArray[0], 2) + Math.Pow(SidesArray[1], 2) - Math.Pow(SidesArray[2], 2) != 0){
                return false; 
            }
            return true;
        }
    }
}