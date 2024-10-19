using System;

namespace Sorts.SortType
{
  public class TreeSort : BaseSort
  {
    public override int[] Execute(int[] array)
    {
      if (array == null || array.Length == 0)
        return Array.Empty<int>();

      var root = new TreeNode(array[0]);

      for (var i = 1; i < array.Length; i++)
        root.Insert(array[i]);

      root.FillArray(array, 0);

      return array;
    }

    private class TreeNode
    {
      private readonly int _data;
      
      private TreeNode _left;
      private TreeNode _right;

      public TreeNode(int data)
      {
        _data = data;
      }

      public void Insert(int data)
      {
        if (data < _data)
        {
          if (_left == null)
            _left = new TreeNode(data);
          else
            _left.Insert(data);
        }
        else
        {
          if (_right == null)
            _right = new TreeNode(data);
          else
            _right.Insert(data);
        }
      }

      public int FillArray(int[] array, int index)
      {
        if (_left != null)
          index = _left.FillArray(array, index);

        array[index++] = _data;

        if (_right != null)
          index = _right.FillArray(array, index);

        return index;
      }
    }
  }
}