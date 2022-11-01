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

}