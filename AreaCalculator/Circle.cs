using AreaCalculator.Models;

namespace AreaCalculator
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }
        /// <summary>
        /// Инициализация круга с полученным радиусом
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается когда радиус меньше или равен нулю</exception>
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть больше нуля");

            Radius = radius;
        }
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>Произведение числа Пи на квадрат радиуса</returns>
        protected override double GetFigureArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
