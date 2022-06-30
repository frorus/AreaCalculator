using AreaCalculator.Models;

namespace AreaCalculator
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Поле для результата проверки треугольника на прямоугольность
        /// </summary>
        private bool _isRightTriangle;
        /// <summary>
        /// Сторона А треугольника
        /// </summary>
        public double SideA { get; set; }
        /// <summary>
        /// Сторона В треугольника
        /// </summary>
        public double SideB { get; set; }
        /// <summary>
        /// Сторона С треугольника
        /// </summary>
        public double SideC { get; set; }
        /// <summary>
        /// Результат проверки треугольника на прямоугольность
        /// </summary>
        public bool IsRightTriangle
        {
            get { return _isRightTriangle = CheckIsRightTriangle(); }
        }
        /// <summary>
        /// Инициализация треугольника с полученными сторонами
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается когда сторона меньше или равна нулю</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0) throw new ArgumentOutOfRangeException(nameof(sideA), "Сторона должна быть больше нуля");
            if (sideB <= 0) throw new ArgumentOutOfRangeException(nameof(sideB), "Сторона должна быть больше нуля");
            if (sideC <= 0) throw new ArgumentOutOfRangeException(nameof(sideC), "Сторона должна быть больше нуля");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <returns>Булево значение после вычисления по теореме Пифагора</returns>
        private bool CheckIsRightTriangle()
        {
            var sidesList = new List<double> { SideA, SideB, SideC };
            var hypotenuse = sidesList.Max();

            return (float)(hypotenuse * hypotenuse) == (float)sidesList.Where(side => side != hypotenuse).Sum(side => side * side);
        }
        /// <summary>
        /// Получить площадь треугольника
        /// </summary>
        /// <returns>Результат вычисления по формуле Герона</returns>
        protected override double GetFigureArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}
