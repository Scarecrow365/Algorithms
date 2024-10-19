namespace Algorithm_Dijkstra
{
  public class Edge
  {
    public GraphVertex ConnectedVertex { get; }

    public int EdgeWeight { get; }

    public Edge(GraphVertex connectedVertex, int weight)
    {
      ConnectedVertex = connectedVertex;
      EdgeWeight = weight;
    }
  }
}