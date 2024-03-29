
namespace Shape.Calculation.Interfaces
{
    /// <summary>
    /// Defines a general shape with methods to calculate its area.
    /// </summary>
    public interface IShape
    {    /// <summary>
         /// Gets the area of the shape. This property calls <see cref="CalculateArea"/> internally.
         /// </summary>
        double Area {  get; }
    }
}
