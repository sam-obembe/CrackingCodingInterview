using Xunit;
using CrackingInterviewDotnet.TreesAndGraphs;
using CrackingInterviewDotnet.Models.GraphAdjacencyList;
using System.Collections.Generic;
using System.Linq;

namespace CrackingInterviewDotnetTests.TreesAndGraphs;

public class TreeAndGraphRunnerTest
{
    public TreeAndGraphRunnerTest()
    {

    }


    [Fact]
    public void RouteBetweenNodesTest()
    {

        var graph = new Graph<string>();
        graph.Vertices = VerticesBuilder();

        var sam = graph.Vertices.Where(x => x.Value.Equals("Sam")).FirstOrDefault();
        var mum = graph.Vertices.Where(x => x.Value.Equals("Mom")).FirstOrDefault();

        var routesExist = TreeAndGraphRunner.RouteBetweenNodes(graph, sam, mum);

        Assert.Equal(true, routesExist);

        //do stuff;
    }


    [Theory]
    [InlineData("hello")]
    public void Test_Two(string testValue)
    {
        //do stuff
    }



    private IEnumerable<Vertex<string>> VerticesBuilder()
    {
        var samVertex = BuildVertex("Sam");
        var daveVertex = BuildVertex("Dave");
        var danVertex = BuildVertex("Dan");
        var dadVertex = BuildVertex("Dad");
        var mumVertext = BuildVertex("Mom");


        samVertex.AdjacentVertices = new List<Vertex<string>>() { daveVertex, danVertex };
        daveVertex.AdjacentVertices = new List<Vertex<string>>() { samVertex, danVertex, mumVertext };
        danVertex.AdjacentVertices = new List<Vertex<string>>() { samVertex, daveVertex, dadVertex };
        dadVertex.AdjacentVertices = new List<Vertex<string>>() { danVertex, mumVertext };


        var vertexList = new List<Vertex<string>>() { samVertex, dadVertex, danVertex, daveVertex, mumVertext };

        return vertexList;
    }


    private Vertex<string> BuildVertex(string val)
    {
        return new Vertex<string>(val);
    }
}