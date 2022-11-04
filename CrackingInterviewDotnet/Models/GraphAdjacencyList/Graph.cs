
using System;
using CrackingInterviewDotnet.Models.GraphAdjacencyList;

public class Graph<T>
{
    public IEnumerable<Vertex<T>> Vertices { get; set; }

    public Graph(IEnumerable<Vertex<T>> vertices)
    {
        Vertices = vertices;
    }
    public Graph()
    {
    }
}
