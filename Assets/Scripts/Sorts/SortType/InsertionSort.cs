namespace Sorts.SortType
{
  public class InsertionSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      for (var i = 1; i < array.Length; i++)
      {
        int key = array[i];
        int j = i;
        while (j > 1 && array[j - 1] > key)
        {
          Swap(ref array[j - 1], ref array[j]);
          j--;
        }
      }

      return array;
    }
  }
}