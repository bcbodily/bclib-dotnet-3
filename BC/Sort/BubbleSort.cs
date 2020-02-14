using System;

namespace BC.Sort
{
    public class BubbleSort<T> : IArraySort<T> where T : IComparable<T>
    {
        private ISortHelper<T> SortHelper { get; }

        public BubbleSort(ISortHelper<T> sortHelper)
        {
            SortHelper = sortHelper;
        }
        public void Sort(T[] array)
        {
            for (int left = 0; left < array.Length; left++)
            {
                for (int right = left + 1; right < array.Length; right++)
                {
                    if (SortHelper.Compare(array, left, right) > 0)
                    {
                        SortHelper.Swap(ref array, left, right);
                    }
                }
            }
        }
    }
}