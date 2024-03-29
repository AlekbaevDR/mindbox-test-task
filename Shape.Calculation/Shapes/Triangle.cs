using Shape.Calculation.Interfaces;

namespace Shape.Calculation.Shapes
{
    /// <summary>
    /// Represents a triangle.
    /// </summary>
    internal class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public double Area { get => CalculateArea(); }
        public bool IsRectangular { get => IsRectangularCalculation(); }

        private double? _area;
        private bool? _isRectangular;

        /// <summary>
        /// Initializes a new instance of the Triangle class with the specified sides.
        /// </summary>
        /// <param name="sideA">The length of side A.</param>
        /// <param name="sideB">The length of side B.</param>
        /// <param name="sideC">The length of side C.</param>
        internal Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        private double CalculateArea()
        {
            if (!_area.HasValue)
            {
                var s = (SideA + SideB + SideC) / 2;
                _area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
            return _area.Value;
        }

        /// <summary>
        /// Determines whether the triangle is rectangular.
        /// </summary>
        /// <returns>True if the triangle is rectangular; otherwise, false.</returns>
        private bool IsRectangularCalculation()
        {
            if (!_isRectangular.HasValue)
                _isRectangular = (SideA < SideB + SideC)
                    && (SideB < SideA + SideC)
                    && (SideC < SideA + SideB)
                    && SideA > 0 && SideB > 0 && SideC > 0;
            return _isRectangular.Value;
        }
    }
}
