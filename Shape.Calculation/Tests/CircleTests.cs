
using FluentAssertions;
using Shape.Calculation.Creators;
using Shape.Calculation.Interfaces;
using Shape.Calculation.Shapes;
using Xunit;

namespace Shape.Calculation.Tests
{
    public class CircleTests
    {
    [Fact]
    public void Circle_WithValidRadius_CalculatesAreaCorrectly()
        {
            var circle = new Circle(5);
            var expectedArea = Math.PI * Math.Pow(5, 2);

            circle.Area.Should().BeApproximately(expectedArea, 0.01);
        }

        [Fact]
        public void Circle_WithZeroRadius_ThrowsIncorrectShapeSizeException()
        {
            Action act = () => new CircleCreator(0).Create();

            act.Should().Throw<IncorrectShapeSizeException>()
                .WithMessage("Circle cannot have such radius 0");
        }
    }
}
