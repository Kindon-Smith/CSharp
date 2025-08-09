using InterviewPrepLib.Algorithms;


namespace Algorithms.Tests;

public class ReverseStringTests
{
    [Theory]
    [InlineData("cba", "abc")]
    [InlineData("?%^!@#T", "T#@!^%?")]
    [InlineData("g", "g")]
    public void ReverseString_Returns_Expected_Reversed_String(string expected, string tested)
    {
        Assert.Equal(expected, ReverseString.Execute(tested));
    }

    [Fact]
    public void ReverseString_Handles_Empty_String()
    {
        Assert.Equal("", ReverseString.Execute(""));
    }

    [Fact]
    public void ReverseString_Handles_Null_String()
    {
        Assert.Throws<ArgumentNullException>(() => ReverseString.Execute(null));
    }
}

