using System.Collections.Generic;
using System.Linq;

namespace Algorithm_Dijkstra
{
  public class AlgorithmDijkstra
  {
    private readonly Graph graph;
    
    private List<GraphVertexInfo> grapeVertexes;

    public AlgorithmDijkstra(Graph graph)
    {
      this.graph = graph;
    }

    public GraphVertexInfo FindUnvisitedVertexWithMinSum()
    {
      var minValue = int.MaxValue;
      GraphVertexInfo minVertexInfo = null;
      
      foreach (var info in grapeVertexes)
      {
        if (info.IsUnvisited && info.EdgesWeightSum < minValue)
        {
          minVertexInfo = info;
          minValue = info.EdgesWeightSum;
        }
      }

      return minVertexInfo;
    }

    public string FindShortestPath(string startName, string finishName)
    {
      return FindShortestPath(graph.FindVertex(startName), graph.FindVertex(finishName));
    }
    
    public string FindShortestPath(GraphVertex startVertex, GraphVertex finishVertex)
    {
      InitInfo();
      
      var root = GetVertexInfo(startVertex);
      root.EdgesWeightSum = 0;
      
      while (true)
      {
        var current = FindUnvisitedVertexWithMinSum();
        if (current == null)
          break;

        SetSumToNextVertex(current);
      }

      return GetPath(startVertex, finishVertex);
    }

    private void InitInfo()
    {
      grapeVertexes = new List<GraphVertexInfo>();
      
      foreach (var vertex in graph.Vertices) 
        grapeVertexes.Add(new GraphVertexInfo(vertex));
    }

    private GraphVertexInfo GetVertexInfo(GraphVertex vertex)
    {
      return grapeVertexes.FirstOrDefault(i => i.Vertex.Equals(vertex));
    }

    private void SetSumToNextVertex(GraphVertexInfo info)
    {
      info.IsUnvisited = false;
      
      foreach (var edge in info.Vertex.Edges)
      {
        var nextInfo = GetVertexInfo(edge.ConnectedVertex);
        var sum = info.EdgesWeightSum + edge.EdgeWeight;

        if (sum >= nextInfo.EdgesWeightSum) 
          continue;
        
        nextInfo.EdgesWeightSum = sum;
        nextInfo.PreviousVertex = info.Vertex;
      }
    }

    private string GetPath(GraphVertex startVertex, GraphVertex endVertex)
    {
      var path = endVertex.Name;
      
      while (startVertex != endVertex)
      {
        endVertex = GetVertexInfo(endVertex).PreviousVertex;
        path = endVertex.Name + path;
      }

      return path;
    }
  }
}