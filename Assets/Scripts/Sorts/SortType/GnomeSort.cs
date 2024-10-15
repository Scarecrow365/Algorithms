namespace Sorts.SortType
{
  public class GnomeSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      var index = 1;
      int nextIndex = index + 1;

      while (index < array.Length)
      {
        if (array[index - 1] >= array[index])
        {
          Swap(ref array[index - 1], ref array[index]);
          index--;

          if (index != 0) 
            continue;
        }
        
        index = IncreaseIndex(ref nextIndex);
      }

      return array;
    }

    private static int IncreaseIndex(ref int nextIndex)
    {
      int index = nextIndex;
      nextIndex++;
      return index;
    }
  }
}