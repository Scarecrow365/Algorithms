namespace Sorts.SortType
{
  public class ShakerSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      for (var i = 0; i < array.Length / 2; i++)
      {
        var swapFlag = false;

        for (int j = i; j < array.Length - i - 1; j++)
          if (array[j] > array[j + 1])
          {
            Swap(ref array[j], ref array[j + 1]);
            swapFlag = true;
          }

        for (int j = array.Length - 2 - i; j > i; j--)
          if (array[j - 1] > array[j])
          {
            Swap(ref array[j - 1], ref array[j]);
            swapFlag = true;
          }

        if (!swapFlag)
          break;
      }

      return array;
    }
  }
}