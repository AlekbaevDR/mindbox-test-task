using Shape.Calculation.Creators;
using Shape.Calculation.Interfaces;
using Shape.Calculation.Shapes;
using Xunit;

namespace Shape.Calculation.Tests
{
    public class ShapeCreatorTests
    {
        [Fact]
        public void Create_WithOneDimension_ReturnsCircle()
        {
            
            var dimensions = new double[] { 5 };
            var shapeCreator = new ShapeCreator(dimensions);

            var shape = shapeCreator.Create();

            Assert.IsType<Circle>(shape);
        }

        [Fact]
        public void Create_WithThreeDimensions_ReturnsTriangle()
        {
            var dimensions = new double[] { 3, 4, 5 };
            var shapeCreator = new ShapeCreator(dimensions);

            var shape = shapeCreator.Create();

            Assert.IsType<Triangle>(shape);
        }

        [Fact]
        public void Create_WithInvalidNumberOfDimensions_ThrowsArgumentException()
        {
            var dimensions = new double[] { }; 
            var shapeCreator = new ShapeCreator(dimensions);

            Assert.Throws<ArgumentException>(() => shapeCreator.Create());
        }

        [Fact]
        public void Create_WithNegativeDimensions_ThrowsIncorrectShapeSizeException()
        {
            
            var dimensions = new double[] { -1 }; // Invalid dimension for a circle
            var shapeCreator = new ShapeCreator(dimensions);

            Assert.Throws<IncorrectShapeSizeException>(() => shapeCreator.Create());
        }
    }
}
