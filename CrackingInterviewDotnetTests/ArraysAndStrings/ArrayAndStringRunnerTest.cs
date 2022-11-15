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



    [Theory]
    [InlineData("pale", "ple")]
    [InlineData("pales", "pale")]
    [InlineData("pale", "bale")]
    public void OneAway_Passes_True(string textA, string textB)
    {
        var isOneAway = ArrayAndStringRunner.OneAway(textA, textB);
        Assert.True(isOneAway);
    }


    [Theory]
    [InlineData("pale", "bake")]
    public void OneAway_Passes_False(string textA, string textB)
    {
        var isOneAway = ArrayAndStringRunner.OneAway(textA, textB);
        Assert.False(isOneAway);
    }


    [Theory]
    [InlineData("aabccccaaa", "a2b1c4a3")]
    public void StringCompression_Passes(string text, string compressed)
    {
        var result = ArrayAndStringRunner.StringCompression(text);
        Assert.Equal(compressed, result);
    }
}