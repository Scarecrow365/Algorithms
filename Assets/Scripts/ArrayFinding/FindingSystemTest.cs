using UnityEngine;

namespace ArrayFinding
{
  public class FindingSystemTest : MonoBehaviour
  {
    [SerializeField] private int target;

    [ContextMenu("Test")]
    public void Test()
    {
      var result = FindingSystem.LinearSearch(target);
      Debug.Log(result == -1 ? "Value not found" : $"Result: {result.ToString()}");
    }
  }
}