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


    [Theory]
    [InlineData("Mr John Smith ")]
    public void URLify_ForValidText_Passes(string text)
    {
        var urlParsed = ArrayAndStringRunner.URLify(text);
        var contains = urlParsed.Contains("%20");

        Assert.True(contains);

    }


    [Theory]
    [InlineData("Tact Coa")]
    [InlineData("opp")]
    [InlineData("yaakk")]
    [InlineData("raacere")]
    public void PalindromePermutation_Passes(string text)
    {
        var isPermutation = ArrayAndStringRunner.PalindromePermutation(text);
        Assert.True(isPermutation);
    }
}