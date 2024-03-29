/*
 * Данный класс позволяет создавать фигуры основываясь на количестве параметров переденных в метод Creat.
 * Изменяя их можно создавать фигуру основываясь на количестве сторон 
*/
using Shape.Calculation.Interfaces;

namespace Shape.Calculation.Creators
{
    /// <summary>
    /// A factory for creating shape instances based on given dimensions.
    /// </summary>
    public class ShapeCreator : IShapeCreator
    {
        private readonly double[] _dimensions;

        /// <summary>
        /// Initializes a new instance of the ShapeCreator class with specified dimensions.
        /// </summary>
        /// <param name="dimensions">The dimensions of the shape to create.</param>
        public ShapeCreator(params double[] dimensions) 
        { 
            _dimensions = dimensions;
        }

        /// <summary>
        /// Creates a new shape instance based on the provided dimensions.
        /// </summary>
        /// <returns>An IShape instance based on the dimensions.</returns>
        /// <exception cref="ArgumentException">Thrown when the number of dimensions is not valid for any shape.</exception>
        public IShape Create()
        {
            switch (_dimensions.Length)
            {
                case 1:return new CircleCreator(_dimensions[0]).Create();
                case 3: return new TriangleCreator(_dimensions[0], _dimensions[1], _dimensions[2]).Create();
                default: throw new ArgumentException("Invalid number of dimensions to determine a shape.");

            }
        }
    }
}
