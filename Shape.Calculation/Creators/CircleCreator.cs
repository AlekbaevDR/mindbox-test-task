using Shape.Calculation.Interfaces;
using Shape.Calculation.Shapes;

namespace Shape.Calculation.Creators
{
    /// <summary>
    /// A factory for creating instances of circles.
    /// </summary>
    public class CircleCreator: IShapeCreator
    {
        private readonly double _radius;

        /// <summary>
        /// Initializes a new instance of the CircleCreator class with a specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle to create.</param>
        public CircleCreator(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Creates a new Circle instance.
        /// </summary>
        /// <returns>A new Circle instance.</returns>
        /// <exception cref="IncorrectShapeSizeException">Thrown when the specified radius is not valid for a circle.</exception>
        public IShape Create()
        {
            return IsValid()
                ? new Circle(_radius)
                : throw new IncorrectShapeSizeException($"Circle cannot have such radius {_radius}");
        }

        /// <summary>
        /// Validates the radius for the circle.
        /// </summary>
        /// <returns>True if the radius is greater than 0; otherwise, false.</returns>
        private bool IsValid() => _radius > 0;
    }
}
