namespace Algorithm_Dijkstra
{
  public class GraphVertexInfo
  {
    public GraphVertex Vertex { get; }
    public GraphVertex PreviousVertex { get; set; }

    public bool IsUnvisited { get; set; }
    public int EdgesWeightSum { get; set; }


    public GraphVertexInfo(GraphVertex vertex)
    {
      Vertex = vertex;
      IsUnvisited = true;
      EdgesWeightSum = int.MaxValue;
      PreviousVertex = null;
    }
  }
}