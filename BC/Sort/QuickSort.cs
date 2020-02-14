using System;
namespace BC.Sort
{
    public class QuickSort<T> : IArraySort<T> where T : IComparable<T>
    {
        private ISortHelper<T> SortHelper { get; }
        private IPartionerTwoWay<T> Partioner {get;}

        public QuickSort(ISortHelper<T> sortHelper, IPartionerTwoWay<T> partioner)
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

            var partitionIndex = Partioner.Partition(ref array, left, right);

            quicksort(ref array, left, partitionIndex - 1);
            quicksort(ref array, partitionIndex + 1, right);
        }
    }
}