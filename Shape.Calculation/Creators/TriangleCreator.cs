/*
 * Данный класс позволяет создавать Треугольники, при этом конструтор данного класса может быть перегружен, 
 * тем самым можно будет создавать треугольник по двум сторонам.
 */
using Shape.Calculation.Interfaces;
using Shape.Calculation.Shapes;

namespace Shape.Calculation.Creators
{
    /// <summary>
    /// A factory for creating instances of triangles.
    /// </summary>
    public class TriangleCreator : IShapeCreator
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <summary>
        /// Initializes a new instance of the TriangleCreator class with specified side lengths.
        /// </summary>
        /// <param name="sideA">The length of side A.</param>
        /// <param name="sideB">The length of side B.</param>
        /// <param name="sideC">The length of side C.</param>
        public TriangleCreator(double sideA, double sideB, double sideC) 
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Creates a new Triangle instance.
        /// </summary>
        /// <returns>A new Triangle instance.</returns>
        /// <exception cref="IncorrectShapeSizeException">Thrown when the specified side lengths are not valid for a triangle.</exception>
        public IShape Create()
        {
            return IsValid()
                ? new Triangle(_sideA, _sideB, _sideC)
                : throw new IncorrectShapeSizeException($"Triangle with such sides is not valid: {_sideA}, {_sideB}, {_sideC}");
        }

        ///<summary>
        /// Validates the side lengths for the triangle.
        /// </summary>
        /// <returns>True if the side lengths form a valid triangle; otherwise, false.</returns>
        bool IsValid() => _sideA > 0 
            && _sideB > 0 && _sideC > 0 
            && _sideA + _sideB > _sideC 
            && _sideA + _sideC > _sideB 
            && _sideB + _sideC > _sideA;
    }
}
