namespace Sorts.SortType
{
  public class SelectionSort : BaseSort
  {
    private int _targetElement;

    public void SelectedIndex(int i) => _targetElement = i;

    public override int[] Execute(int[] array)
    {
      while (_targetElement != array.Length)
      {
        int index = IndexOfMin(array, _targetElement);
        
        if (index != _targetElement) 
          Swap(ref array[index], ref array[_targetElement]);

        _targetElement++;
      }

      return array;
    }

    private static int IndexOfMin(int[] array, int n)
    {
      int result = n;

      for (int i = n; i < array.Length; ++i)
      {
        if (array[i] < array[result])
          result = i;
      }

      return result;
    }
  }
}