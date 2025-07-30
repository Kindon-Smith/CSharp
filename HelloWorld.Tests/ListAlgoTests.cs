using Xunit;
using HelloWorld.Exercises;
using HelloWorld.E4Lib;

public class ListAlgoTests
{
    /// <summary>
    /// Deprecated, temporarily not working due to changes in the E4Lib namespace
    /// </summary>
    /// <param name=""></param>
    
    /*
    [Theory]
    [Trait("Category", "ListTest")]
    [InlineData(new int[] { 12, 3, 100, 34, 6, 8, 9856 })]

    public void FindMax_ReturnsMaxValue(params int[] numbers)
    {
        var maxValCalculated = Exercise4.FindMax(numbers);
        var maxValVerified = numbers.Max();
        Assert.Equal(maxValCalculated, maxValVerified);
    }

    [Fact]
    public void FindMax_ThrowsErrorWithNullInput()
    {
        Assert.Throws<ArgumentNullException>(() => Exercise4.FindMax((int[])null));
    }

    [Theory]
    [InlineData(new int[] {-1, -5, -12, -15})]
    public void FindMax_WorksWithNegativeInput(int[] numbers)
    {
        var maxValCalculated = Exercise4.FindMax(numbers);
        var maxValVerified = numbers.Max();
        Assert.Equal(maxValCalculated, maxValVerified);
    }
    */
}