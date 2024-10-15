namespace Sorts.SortType
{
  public class MergeSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      return RecursiveMergeSort(array, 0, array.Length - 1);
    }

    private static int[] RecursiveMergeSort(int[] array, int lowIndex, int highIndex)
    {
      if (lowIndex >= highIndex)
        return array;

      int middleIndex = (lowIndex + highIndex) / 2;
      RecursiveMergeSort(array, lowIndex, middleIndex);
      RecursiveMergeSort(array, middleIndex + 1, highIndex);
      Merge(array, lowIndex, middleIndex, highIndex);
      return array;
    }

    private static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
    {
      int left = lowIndex;
      int right = middleIndex + 1;
      var tempArray = new int[highIndex - lowIndex + 1];
      var index = 0;

      while (left <= middleIndex && right <= highIndex)
      {
        if (array[left] < array[right])
        {
          tempArray[index] = array[left];
          left++;
        }
        else
        {
          tempArray[index] = array[right];
          right++;
        }

        index++;
      }

      for (int i = left; i <= middleIndex; i++)
      {
        tempArray[index] = array[i];
        index++;
      }

      for (int i = right; i <= highIndex; i++)
      {
        tempArray[index] = array[i];
        index++;
      }

      for (var i = 0; i < tempArray.Length; i++) 
        array[lowIndex + i] = tempArray[i];
    }
  }
}