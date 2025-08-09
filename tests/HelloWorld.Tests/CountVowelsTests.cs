using Xunit;
using InterviewPrepLib.Algorithms;

namespace Algorithms.Tests;

public class CountVowelsTests
{
    [Theory]
    [InlineData(3, "hello world")]
    [InlineData(0, "z")]
    [InlineData(14, "aueohhnvfjnvjfhbluiopaehdgjn,clkeuoiu")]
    public void CountVowelsReturnsCorrectCount(int expected, string input)
    {
        Assert.Equal(expected, CountVowels.Execute(input));
    }

    [Fact]
    public void CountVowelsHandlesEmptyString()
    {
        Assert.Equal(0, CountVowels.Execute(""));
    }

    [Fact]
    public void CountVowelsHandlesUpperCaseVowels()
    {
        Assert.Equal(10, CountVowels.Execute("AbcDEiUoIOuae"));
    }

    [Fact]
    public void CountVowelsHandlesNullString()
    {
        Assert.Throws<ArgumentNullException>(() => CountVowels.Execute(null));
    }
}