
using FluentAssertions;
using Shape.Calculation.Creators;
using Shape.Calculation.Interfaces;
using Shape.Calculation.Shapes;
using Xunit;

namespace Shape.Calculation.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        public void Triangle_WithValidSidesAndRectangular_ChecksIsRectangularCorrectly(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            triangle.IsRectangular.Should().BeTrue();
        }

        [Fact]
        public void Triangle_WithValidSides_CalculatesAreaCorrectly()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6; 

            triangle.Area.Should().BeApproximately(expectedArea, 0.01);
        }

        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(-1, 10, 12)]
        public void Triangle_WithInvalidSides_ThrowsIncorrectShapeSizeException(double a, double b, double c)
        {
            Action act = () => new TriangleCreator(a, b, c).Create();

            act.Should().Throw<IncorrectShapeSizeException>()
                .WithMessage($"Triangle with such sides is not valid: {a}, {b}, {c}");
        }
    }
}
