namespace Sorts.SortType
{
  public class ShellSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      int halfArrayLength = array.Length / 2;

      while (halfArrayLength >= 1)
      {
        for (int i = halfArrayLength; i < array.Length; i++)
        {
          int j = i;
          while (j >= halfArrayLength && array[j - halfArrayLength] > array[j])
          {
            Swap(ref array[j], ref array[j - halfArrayLength]);
            j -= halfArrayLength;
          }
        }
        
        halfArrayLength /= 2;
      }

      return array;
    }
  }
}