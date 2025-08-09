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
    public void ReverseStringHandlesEmptyString()
    {
        Assert.Equal("", ReverseString.Execute(""));
    }
}

