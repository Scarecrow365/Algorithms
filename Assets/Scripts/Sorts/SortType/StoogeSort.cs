namespace Sorts.SortType
{
  public class StoogeSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      return RecursiveExecute(array, 0, array.Length - 1);
    }

    private static int[] RecursiveExecute(int[] array, int startIndex, int endIndex)
    {
      if (array[startIndex] > array[endIndex])
        Swap(ref array[startIndex], ref array[endIndex]);

      if (endIndex - startIndex <= 1) 
        return array;
      
      int len = (endIndex - startIndex + 1) / 3;
      RecursiveExecute(array, startIndex, endIndex - len);
      RecursiveExecute(array, startIndex + len, endIndex);
      RecursiveExecute(array, startIndex, endIndex - len);
      
      return array;
    }
  }
}