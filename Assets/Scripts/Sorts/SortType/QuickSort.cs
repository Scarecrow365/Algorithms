namespace Sorts.SortType
{
  public class QuickSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      return Sort(array, 0, array.Length - 1);
    }

    private static int[] Sort(int[] array, int minIndex, int maxIndex)
    {
      if (minIndex >= maxIndex) return array;

      int pivotIndex = Partition(array, minIndex, maxIndex);
      Sort(array, minIndex, pivotIndex - 1);
      Sort(array, pivotIndex + 1, maxIndex);

      return array;
    }

    private static int Partition(int[] array, int minIndex, int maxIndex)
    {
      int pivot = minIndex - 1;

      for (int i = minIndex; i < maxIndex; i++)
      {
        if (array[i] >= array[maxIndex])
          continue;

        pivot++;
        Swap(ref array[pivot], ref array[i]);
      }

      pivot++;
      Swap(ref array[pivot], ref array[maxIndex]);
      return pivot;
    }
  }
}