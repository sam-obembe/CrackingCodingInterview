
using CrackingInterviewDotnet.Models.GraphAdjacencyList;

namespace CrackingInterviewDotnet.TreesAndGraphs
{
    public class TreeAndGraphRunner
    {
        /// <summary>
        /// 2.1 Given a directed graph and two nodes, design an algorithm to find out whether there is a route from S to E.
        /// </summary>
        /// <returns>bool</returns>
        public static bool RouteBetweenNodes(Graph<string> graph, Vertex<string> point_S, Vertex<string> point_E)
        {
            var pointsExist = graph.Vertices.Where(x => x.Value.Equals(point_S.Value) || x.Value.Equals(point_E.Value));

            if (!(pointsExist.Count() > 0))
            {
                return false;
            }
            var validChildren = point_S.AdjacentVertices.Where(x => x.Value.Equals(point_E.Value));

            if (validChildren.Count() > 0)
            {
                return true;
            }
            else
            {
                foreach (var child in point_S.AdjacentVertices)
                {
                    var exists = RouteBetweenNodes(graph, child, point_E);
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