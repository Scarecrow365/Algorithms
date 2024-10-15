namespace Sorts.SortType
{
  public class PancakeSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      for (int subArrayLength = array.Length - 1; subArrayLength >= 0; subArrayLength--)
      {
        int indexOfMax = IndexOfMax(array, subArrayLength);

        if (indexOfMax == subArrayLength)
          continue;

        Flip(array, indexOfMax);
        Flip(array, subArrayLength);
      }

      return array;
    }

    private static int IndexOfMax(int[] array, int index)
    {
      var result = 0;

      for (var i = 1; i <= index; ++i)
        if (array[i] > array[result])
          result = i;

      return result;
    }

    private static void Flip(int[] array, int end)
    {
      for (var start = 0; start < end; start++, end--) 
        Swap(ref array[start], ref array[end]);
    }
  }
}