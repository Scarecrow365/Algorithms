namespace Sorts.SortType
{
  public class StoogeSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      RecursiveExecute(array, 0, array[^1]);
      return array;
    }

    private static void RecursiveExecute(int[] array, int startIndex, int endIndex)
    {
      if (array[startIndex] > array[endIndex])
        Swap(ref array[startIndex], ref array[endIndex]);

      if (endIndex - startIndex <= 1)
        return;

      int len = (endIndex - startIndex + 1) / 3;
      RecursiveExecute(array, startIndex, endIndex - len);
      RecursiveExecute(array, startIndex + len, endIndex);
      RecursiveExecute(array, startIndex, endIndex - len);
    }
  }
}