﻿namespace Sorts.SortType
{
    public class BubbleSort : ISort
    {
        public int[] Execute(int[] array)
        {
            var length = array.Length;
            
            for (var i = 1; i < length; i++)
            {
                for (var j = 0; j < length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
        
        private static void Swap(ref int i, ref int j) => (i, j) = (j, i);
    }
}