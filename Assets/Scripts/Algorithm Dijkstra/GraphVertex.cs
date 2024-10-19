using System.Collections.Generic;

namespace Algorithm_Dijkstra
{
  public class GraphVertex
  {
    public string Name { get; }
    public List<Edge> Edges { get; }

    public GraphVertex(string vertexName)
    {
      Name = vertexName;
      Edges = new List<Edge>();
    }
    
    public void AddEdge(Edge newEdge) => Edges.Add(newEdge);
    public void AddEdge(GraphVertex vertex, int edgeWeight) => AddEdge(new Edge(vertex, edgeWeight));
  }
}