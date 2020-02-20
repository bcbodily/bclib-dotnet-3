using System;

namespace BC.Sorting.Partitioners
{
    /// <summary>
    /// A two-way partitioner that partitions that utilizes the Lomuto partitioning scheme
    /// </summary>
    /// <typeparam name="T">the type of elements in the array being partioned</typeparam>
    public class LomutoPartitioner<T> : IPartitionerTwoWay<T> where T : IComparable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="LomutoPartitioner"/> with a specified <see cref="ISortHelper"/>
        /// </summary>
        /// <param name="sortHelper">the sort helper this instance will use to perform basic operations; cannot be null</param>
        public LomutoPartitioner(ISortHelper<T> sortHelper)
        {
            if (sortHelper == null)
            {
                throw new ArgumentException("Illegal null sortHelper; sortHelper must be non-null");
            }

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