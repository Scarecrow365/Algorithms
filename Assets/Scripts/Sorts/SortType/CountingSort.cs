namespace Sorts.SortType
{
  public class CountingSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      SearchMinMaxRange(array, out int min, out int max);

      var correctionFactor = CalculateCorrectionFactor(min, ref max);
      var count = CalculateCount(array, max, correctionFactor);

      var index = 0;
      for (var i = 0; i < count.Length; i++)
      {
        for (var j = 0; j < count[i]; j++)
        {
          array[index] = i - correctionFactor;
          index++;
        }
      }

      return array;
    }

    private static void SearchMinMaxRange(int[] array, out int min, out int max)
    {
      min = array[0];
      max = array[0];

      foreach (int element in array)
      {
        if (element > max)
        {
          max = element;
        }
        else if (element < min)
        {
          min = element;
        }
      }
    }

    private static int CalculateCorrectionFactor(int min, ref int max)
    {
      int correctionFactor = min != 0 ? -min : 0;
      max += correctionFactor;
      return correctionFactor;
    }

    private static int[] CalculateCount(int[] array, int max, int correctionFactor)
    {
      var count = new int[max + 1];
      foreach (int item in array)
      {
        count[item + correctionFactor]++;
      }

      return count;
    }
  }
}