using Xunit;
using System.Collections.Generic;
using CrackingInterviewDotnet.LinkedLists;
using System.Linq;

namespace CrackingInterviewDotnetTests.LinkedLists;

public class LinkedListRunnerTest
{

    [Fact]
    public void RemoveDups_WithDups_Passes()
    {
        string[] text = new string[] { "hi", "go", "hi", "come" };

        var linkedList = new LinkedList<string>(text);


        LinkedListRunner.RemoveDups(linkedList);

        var his = linkedList.Where(x => x.Equals("hi"));


        Assert.Equal(1, his.Count());

    }


    [Theory]
    [InlineData("tim,sarah,anthony,cleopatra", 2)]
    [InlineData("tim,sarah,anthony,cleopatra", 3)]
    public void FindKthToLast(string text, int k)
    {
        string[] textArray = text.Split(",");
        var textList = new LinkedList<string>(textArray);

        var kthToLast = LinkedListRunner.KToLastElement(textList, k);

        Assert.Equal(textArray[textArray.Count() - k], kthToLast);
    }
}