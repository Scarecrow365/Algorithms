using Random = System.Random;

namespace Sorts.SortType
{
  public class BogoSort : ISort
  {
    public int[] Execute(int[] array)
    {
      while (!IsSorted(array)) array = RandomPermutation(array);
      return array;
    }

    private static bool IsSorted(int[] array)
    {
      for (var i = 0; i < array.Length - 1; i++)
        if (array[i] > array[i + 1])
          return false;

      return true;
    }

    private static int[] RandomPermutation(int[] array)
    {
      Random random = new();
      int n = array.Length;

      while (n > 1)
      {
        n--;
        int i = random.Next(n + 1);
        (array[i], array[n]) = (array[n], array[i]);
      }

      return array;
    }
  }
}