namespace Sorts.SortType
{
  public abstract class BaseSort
  {
    public abstract int[] Execute(int[] array);

    protected static void Swap(ref int i, ref int j) => (i, j) = (j, i);
  }
}