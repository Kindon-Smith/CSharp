using InterviewPrepLib.DataStructures;

namespace Datastructures.Tests;

public class ShapeTests
{
    [Theory]
    [InlineData(5, Math.PI * 5 * 5)]
    [InlineData(3, Math.PI * 3 * 3)]
    public void GetArea_Returns_Correct_Area_For_Circle(double radius, double expectedArea)
    {
        var newCircle = new Circle(radius);
        Assert.Equal(expectedArea, newCircle.GetArea());
    }
}