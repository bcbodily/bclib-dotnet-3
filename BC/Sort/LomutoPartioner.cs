using System;

namespace BC.Sort
{
    public class LomutoPartioner<T> : IPartitionerTwoWay<T> where T : IComparable<T>
    {
        public LomutoPartioner(ISortHelper<T> sortHelper)
        {
            SortHelper = sortHelper;
        }

        private ISortHelper<T> SortHelper { get; }

        public int Partition(ref T[] array, int left, int right)
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
    }
}