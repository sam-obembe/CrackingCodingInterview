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


    [Theory]
    [InlineData("batt", "ttab")]
    [InlineData("data", "tada")]
    public void CheckPermutation_ForPermutations_Passes(string a, string b)
    {
        var result = ArrayAndStringRunner.CheckPermutation(a, b);
        Assert.True(result);

    }

    [Theory]
    [InlineData("house", "home")]
    [InlineData("council", "counsel")]
    public void CheckPermutation_ForNonPermutations_Fails(string a, string b)
    {
        var result = ArrayAndStringRunner.CheckPermutation(a, b);
        Assert.False(result);

    }
}