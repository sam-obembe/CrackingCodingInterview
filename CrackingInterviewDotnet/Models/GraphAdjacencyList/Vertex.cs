
using System;
using System.Linq;

namespace CrackingInterviewDotnet.Models.GraphAdjacencyList;
public class Vertex<T>
{
    public T Value { get; set; }

    public List<Vertex<T>> AdjacentVertices { get; set; }
    public Vertex(T value)
    {
        Value = value;
    }

    public void AddAdjacentVertex(Vertex<T> vertex)
    {
        AdjacentVertices.Add(vertex);
    }
}
