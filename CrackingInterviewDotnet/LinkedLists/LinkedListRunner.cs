using System.Linq;
using CrackingInterviewDotnet.LinkedLists;

namespace CrackingInterviewDotnet.LinkedLists;
public class LinkedListRunner
{

    /// <summary>
    /// 2.1 Write code to remove duplicates from an unsorted linked list
    /// </summary>
    /// <param name="listWithDups"></param>
    /// <returns></returns>
    public static LinkedList<string> RemoveDups(LinkedList<string> listWithDups)
    {
        var itemCount = new Dictionary<string, int>();

        var currentNode = listWithDups.First;

        while (currentNode?.Next is not null)
        {
            if (!itemCount.ContainsKey(currentNode.Value))
            {
                itemCount[currentNode.Value] = 1;
                currentNode = currentNode.Next;
            }
            else
            {
                var next = currentNode.Next;
                listWithDups.Remove(currentNode);
                currentNode = next;
            }
        }
        return listWithDups;
    }

    /// <summary>
    /// 2.2 Implement an algorithm to find the kth to last element of a singly linked list
    /// </summary>
    /// <param name="list"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static string KToLastElement(LinkedList<string> list, int k)
    {
        //tim -> sarah -> anthony -> cleopatra
        //second to last = anthony

        //convert to array, return elem and array.count-2

        var elementArray = list.ToArray();

        return elementArray[elementArray.Count() - k];

    }

}