using Sorts.SortType;
using UnityEngine;

namespace Sorts
{
  public class SortTest : MonoBehaviour
  {
    [SerializeField] private SortTypes currentSortType = SortTypes.BubbleSort;
    [SerializeField] private int[] array = { 1, 2, 4, 5, 7, 6, 8, 3, 54, 18, 27, 57 };

    [ContextMenu("Execute")]
    private void Execute()
    {
      SortingSystem.Execute(currentSortType, array);
    }
  }
}