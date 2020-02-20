using System;
namespace BC.Sorting.Sorts
{
    public class QuickSort2<T> : IArraySort<T> where T : IComparable<T>
    {
        private ISortHelper<T> SortHelper { get; }
        private IPartitionerThreeWay<T> Partioner { get; }

        public QuickSort2(ISortHelper<T> sortHelper, IPartitionerThreeWay<T> partioner)
        {
            SortHelper = sortHelper;
            Partioner = partioner;
        }

        public void Sort(T[] array)
        {
            quicksort(ref array, 0, array.Length - 1);
        }

        public int partition(ref T[] array, int left, int right)
        {
            for (var current = left; current < right; current++)
            {
                if (SortHelper.Compare(array, current, right) < 0)
                {
                    SortHelper.Swap(ref array, left, current);
                    left++;
                }
            }

            SortHelper.Swap(ref array, left, right);
            return left;
        }

        private void quicksort(ref T[] array, int left, int right)
        {
            if (right <= left)
                return;

            var breaks = Partioner.Partition(ref array, left, right);

            quicksort(ref array, left, breaks.left - 1);
            quicksort(ref array, breaks.right, right + 1);
        }
    }
}