using UnityEngine;

namespace Algorithm_Dijkstra
{
  public class TestGraph : MonoBehaviour
  {
    private const string StartPoint = "A";
    private const string FinishPoint = "G";
    
    [ContextMenu("Execute")]
    private void Execute()
    {
      var graph = InitGraph();
      FindShortestPath(graph);
    }

    private static void FindShortestPath(Graph graph)
    {
      var pathFinder = new AlgorithmDijkstra(graph);
      var path = pathFinder.FindShortestPath(StartPoint, FinishPoint);
      Debug.Log(path);
    }

    private static Graph InitGraph()
    {
      var graph = new Graph();

      InitVertices(graph);
      InitEdges(graph);
      
      return graph;
    }

    private static void InitEdges(Graph graph)
    {
      graph.AddEdge("A", "B", RandomWeight());
      graph.AddEdge("A", "C", RandomWeight());
      graph.AddEdge("A", "D", RandomWeight());
      graph.AddEdge("B", "C", RandomWeight());
      graph.AddEdge("B", "E", RandomWeight());
      graph.AddEdge("C", "D", RandomWeight());
      graph.AddEdge("C", "E", RandomWeight());
      graph.AddEdge("C", "F", RandomWeight());
      graph.AddEdge("D", "F", RandomWeight());
      graph.AddEdge("E", "F", RandomWeight());
      graph.AddEdge("E", "G", RandomWeight());
      graph.AddEdge("F", "G", RandomWeight());
    }

    private static void InitVertices(Graph graph)
    {
      graph.AddVertex("A");
      graph.AddVertex("B");
      graph.AddVertex("C");
      graph.AddVertex("D");
      graph.AddVertex("E");
      graph.AddVertex("F");
      graph.AddVertex("G");
    }

    private static int RandomWeight() => Random.Range(0, 100);
  }
}