using Xunit;
using CrackingInterviewDotnet.ArraysAndStrings;

namespace CrackingInterviewDotnetTests.ArraysAndStrings;

public class ArrayAndStringRunnerTest
{
    [Theory]
    [InlineData("hi")]
    [InlineData("I am boy")]
    public void IsUnique_ForStringWithUnique_Passes(string testString)
    {
        var result = ArrayAndStringRunner.IsUnique(testString);
        Assert.Equal(true, result);
    }

    [Theory]
    [InlineData("sorrow")]
    [InlineData("turn around")]
    public void IsUnique_ForStringWithoutUnique_Fails(string testString)
    {
        var result = ArrayAndStringRunner.IsUnique(testString);
        Assert.Equal(false, result);
    }
}