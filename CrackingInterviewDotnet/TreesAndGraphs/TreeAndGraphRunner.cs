
using CrackingInterviewDotnet.Models.GraphAdjacencyList;

namespace CrackingInterviewDotnet.TreesAndGraphs
{
    public class TreeAndGraphRunner
    {
        /// <summary>
        /// Given a directed graph and two nodes, design an algorithm to find out whether there is a route from S to E.
        /// </summary>
        /// <returns>bool</returns>
        public static bool RouteBetweenNodes(Graph<string> graph, Vertex<string> pointS, Vertex<string> pointE)
        {
            var pointsExist = graph.Vertices.Where(x => x.Value.Equals(pointS.Value) || x.Value.Equals(pointE.Value));

            if (!(pointsExist.Count() > 0))
            {
                return false;
            }
            var validChildren = pointS.AdjacentVertices.Where(x => x.Value.Equals(pointE.Value));

            if (validChildren.Count() > 0)
            {
                return true;
            }
            else
            {
                foreach (var child in pointS.AdjacentVertices)
                {
                    var exists = RouteBetweenNodes(graph, child, pointE);
                    if (exists)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

    }
}