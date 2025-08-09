using System.Runtime.CompilerServices;
using InterviewPrepLib.Algorithms;

namespace Algorithms.Tests;

public class AnagramTests
{
    [Theory]
    [InlineData("listen", "silent", true)]
    [InlineData("hello", "world", false)]
    [InlineData("?><", "<>?", true)]
    public void AnagramCheck_Returns_True_If_Anagram(string s1, string s2, bool expected)
    {
        bool result = AnagramCheck.Execute(s1, s2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AnagramCheck_ThrowsArgumentNullException_WhenFirstInputIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => AnagramCheck.Execute(null, "a"));
    }

    [Fact]
    public void AnagramCheck_ThrowsArgumentNullException_WhenSecondInputIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => AnagramCheck.Execute("bca", null));
    }
}