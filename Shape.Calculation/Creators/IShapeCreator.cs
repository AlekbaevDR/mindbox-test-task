using Shape.Calculation.Interfaces;

namespace Shape.Calculation.Creators
{
    /// <summary>
    /// Defines a factory for creating shapes.
    /// </summary>
    public interface IShapeCreator
    {
        /// <summary>
        /// Creates an instance of a shape.
        /// </summary>
        /// <returns>An IShape instance.</returns>
        IShape Create();
    }
}
