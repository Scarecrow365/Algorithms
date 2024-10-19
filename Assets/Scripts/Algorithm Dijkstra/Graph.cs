using System.Collections.Generic;
using System.Linq;

namespace Algorithm_Dijkstra
{
  public class Graph
  {
    public List<GraphVertex> Vertices { get; } = new();

    public void AddVertex(string vertexName) => Vertices.Add(new GraphVertex(vertexName));
    public GraphVertex FindVertex(string vertexName) => Vertices.FirstOrDefault(v => v.Name.Equals(vertexName));

    public void AddEdge(string firstName, string secondName, int weight)
    {
      var v1 = FindVertex(firstName);
      var v2 = FindVertex(secondName);

      if (v2 == null || v1 == null) return;

      v1.AddEdge(v2, weight);
      v2.AddEdge(v1, weight);
    }
  }
}