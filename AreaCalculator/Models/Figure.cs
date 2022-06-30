namespace AreaCalculator.Models
{
    /// <summary>
    /// Базовый класс фигуры
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Поле для площади фигуры
        /// </summary>
        private double _area;
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area
        {
            get { return _area = GetFigureArea(); }
        }
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        protected abstract double GetFigureArea();
    }
}