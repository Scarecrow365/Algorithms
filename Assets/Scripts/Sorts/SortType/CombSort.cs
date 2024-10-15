namespace Sorts.SortType
{
  public class CombSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      int arrayLength = array.Length;
      int currentStep = arrayLength - 1;

      while (currentStep > 1)
      {
        for (var i = 0; i + currentStep < array.Length; i++)
        {
          if (array[i] > array[i + currentStep])
          {
            Swap(ref array[i], ref array[i + currentStep]);
          }
        }

        currentStep = GetNextStep(currentStep);
      }

      for (var i = 1; i < arrayLength; i++)
      {
        var swapFlag = false;

        for (var j = 0; j < arrayLength - i; j++)
        {
          if (array[j] <= array[j + 1]) 
            continue;
          
          Swap(ref array[j], ref array[j + 1]);
          swapFlag = true;
        }

        if (!swapFlag)
          break;
      }

      return array;
    }

    private static int GetNextStep(int s)
    {
      s = s * 1000 / 1247;
      return s > 1 ? s : 1;
    }
  }
}