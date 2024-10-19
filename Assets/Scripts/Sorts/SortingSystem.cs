using System;
using Sorts.SortType;

namespace Sorts
{
  public static class SortingSystem
  {
    public static int[] Execute(SortTypes sortTypes, int[] array)
    {
      BaseSort currentBaseSort = sortTypes switch
      {
        SortTypes.BogoSort => new BogoSort(),
        SortTypes.TreeSort => new TreeSort(),
        SortTypes.CombSort => new CombSort(),
        SortTypes.ShellSort => new ShellSort(),
        SortTypes.MergeSort => new MergeSort(),
        SortTypes.QuickSort => new QuickSort(),
        SortTypes.GnomeSort => new GnomeSort(),
        SortTypes.BubbleSort => new BubbleSort(),
        SortTypes.ShakerSort => new ShakerSort(),
        SortTypes.StoogeSort => new StoogeSort(),
        SortTypes.PancakeSort => new PancakeSort(),
        SortTypes.CountingSort => new CountingSort(),
        SortTypes.SelectionSort => new SelectionSort(),
        SortTypes.InsertionSort => new InsertionSort(),
        _ => throw new ArgumentOutOfRangeException(nameof(sortTypes), sortTypes, null)
      };

      return currentBaseSort.Execute(array);
    }

    public static int[] Execute(SortTypes sortTypes, int[] array, int selectedSortingIndex)
    {
      if (sortTypes != SortTypes.SelectionSort) 
        return Execute(sortTypes, array);
      
      SelectionSort selectionSort = new();
      selectionSort.SelectedIndex(selectedSortingIndex);
      return selectionSort.Execute(array);
    }
  }
}