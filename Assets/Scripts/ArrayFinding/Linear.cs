namespace ArrayFinding
{
  public static class Linear
  {
    public static int SearchIndex(int[] array, int key)
    {
      if (!IsArrayValid(array)) 
        return -1;
      
      return LinearSearch(array, key);
    }

    public static int MinIndex(int[] array)
    {
      if (!IsArrayValid(array)) 
        return -1;

      var indexMin = 0;
      int min = array[0];

      for (var i = 1; i < array.Length; ++i)
      {
        if (array[i].CompareTo(min) < 0)
        {
          min = array[i];
          indexMin = i;
        }
      }

      return indexMin;
    }

    public static bool MinValue(int[] array, out int value)
    {
      if (!IsArrayValid(array))
      {
        value = -1;
        return false;
      }

      value = array[0];
      for (var i = 1; i < array.Length; ++i)
      {
        if (array[i].CompareTo(value) < 0)
          value = array[i];
      }

      return true;
    }

    public static bool MaxValue(int[] array, out int value)
    {
      if (!IsArrayValid(array))
      {
        value = -1;
        return false;
      }

      value = 0;
      for (var i = 1; i < array.Length; ++i)
      {
        if (array[i].CompareTo(value) > 0)
          value = array[i];
      }

      return true;
    }

    public static int MaxIndex(int[] array)
    {
      if (!IsArrayValid(array)) return -1;

      var indexMax = 0;
      int max = array[0];

      for (var i = 1; i < array.Length; ++i)
      {
        if (array[i].CompareTo(max) > 0)
        {
          max = array[i];
          indexMax = i;
        }
      }

      return indexMax;
    }

    private static int LinearSearch(int[] array, int key)
    {
      for (var i = 0; i < array.Length; ++i)
      {
        if (array[i].Equals(key))
          return i;
      }

      return -1;
    }

    private static bool IsArrayValid(int[] array) => array is { Length: > 0 };
  }
}