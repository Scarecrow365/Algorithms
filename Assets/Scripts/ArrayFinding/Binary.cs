namespace ArrayFinding
{
  public static class Binary
  {
    public static int SearchIndex(int[] array, int key)
    {
      if (!IsArrayValid(array)) 
        return -1;
      
      return BinarySearch(array, key, 0, array.Length - 1);
    }

    private static int BinarySearch(int[] array, int searchedValue, int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex) return -1;

      int middleIndex = (firstIndex + lastIndex) / 2;
      int middleValue = array[middleIndex];

      if (middleValue == searchedValue) return middleIndex;

      return middleValue > searchedValue
        ? BinarySearch(array, searchedValue, firstIndex, middleIndex - 1)
        : BinarySearch(array, searchedValue, middleIndex + 1, lastIndex);
    }

    private static bool IsArrayValid(int[] array) => array is { Length: > 0 };
  }
}