using System.Text;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ArrayFinding
{
  public static class FindingSystem
  {
    public static int BinarySearch(int targetValue)
    {
      return Binary.SearchIndex(GenerateRandomNumberForArray(), targetValue);
    }

    public static int LinearSearch(int targetValue)
    {
      return Linear.SearchIndex(GenerateRandomNumberForArray(), targetValue);
    }

    public static int LinearMinIndex()
    {
      return Linear.MinIndex(GenerateRandomNumberForArray());
    }

    public static int LinearMaxIndex()
    {
      return Linear.MaxIndex(GenerateRandomNumberForArray());
    }

    public static bool LinearMinValue(out int value)
    {
      return Linear.MinValue(GenerateRandomNumberForArray(), out value);
    }

    public static bool LinearMaxValue(out int value)
    {
      return Linear.MaxValue(GenerateRandomNumberForArray(), out value);
    }

    private static int[] GenerateRandomNumberForArray()
    {
      var sr = new StringBuilder();
      sr.Append("Array is: ");

      int min = Random.Range(-(byte.MaxValue / 2), 0);
      int max = Random.Range(0, byte.MaxValue / 2);
      int lenght = Random.Range(1, byte.MaxValue / 2);

      var array = new int[lenght];
      for (var i = 0; i < array.Length; i++)
      {
        array[i] = Random.Range(min, max);
        sr.Append($"{array[i].ToString()}, ");
      }

      Debug.Log(sr);

      return array;
    }
  }
}