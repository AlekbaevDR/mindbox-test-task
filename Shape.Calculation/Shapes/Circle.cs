using Shape.Calculation.Interfaces;

namespace Shape.Calculation.Shapes
{
    /// <summary>
    /// Represents a circle.
    /// </summary>
    internal class Circle : IShape
    {
        public double Radius { get; }
        public double Area { get => CalculateArea(); }

        private double? _area;

        /// <summary>
        /// Initializes a new instance of the Circle class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        internal Circle(double radius)
        {
            Radius = radius;
        }
        
        /// <summary>
        /// Calculates the area of the circle using the formula A = πr².
        /// </summary>
        /// <returns>The area of the circle.</returns>
        private double CalculateArea()
        {
            if (!_area.HasValue)
            {
               _area = Math.PI * Math.Pow(Radius, 2);
            }

            return _area.Value;
        }
    }
}
