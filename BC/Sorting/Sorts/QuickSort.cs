using System;
namespace BC.Sorting.Sorts
{
    /// <summary>
    /// A sorting algorithm that implements QuickSort, with a 1-way partitioning approach
    /// </summary>
    /// <typeparam name="T">the type of elements this sort works with</typeparam>
    public class QuickSort<T> : IArraySort<T> where T : IComparable<T>
    {
        /// <summary>
        /// A <see cref="ISortHelper"/> that performs basic operations
        /// </summary>
        /// <value>The <see cref="ISortHelper"/> this sort uses to perform basic operations</value>
        private ISortHelper<T> SortHelper { get; }

        /// <summary>
        /// A <see cref="IPartitionerTwoWay"/> that performs the partitioning
        /// </summary>
        /// <value>the <see cref="IPartitionerTwoWay"/> this sort uses to perform partitioning</value>
        private IPartitionerTwoWay<T> Partitioner { get; }

        /// <summary>
        /// Creates a new instance of <see cref="QuickSort"/> with a specified sort helper and partitioner
        /// </summary>
        /// <param name="sortHelper">the <see cref="ISortHelper"/> this instance will use to perform basic operations; cannot be null</param>
        /// <param name="partitioner">the <see cref="IPartitionerTwoWay"/> this instance will use to perform partitioning; cannot be null</param>
        public QuickSort(ISortHelper<T> sortHelper, IPartitionerTwoWay<T> partitioner)
        {
            if (sortHelper == null)
                throw new ArgumentNullException("sortHelper must be non-null");

            if (partitioner == null)
                throw new ArgumentNullException("partitioner must be non-null");

            SortHelper = sortHelper;
            Partitioner = partitioner;
        }

        ///<inheritdoc/>
        public void Sort(T[] array)
        {
            quicksort(ref array, 0, array.Length - 1);
        }

        /// <summary>
        /// Performs the quick sort by recursively partitioning and sorting the specified array/range
        /// </summary>
        /// <param name="array">the array to sort</param>
        /// <param name="left">the left index of the range to sort</param>
        /// <param name="right">the right index of the range to sort</param>
        private void quicksort(ref T[] array, int left, int right)
        {
            if (right <= left)
                return;

            var partitionIndex = Partitioner.Partition(ref array, left, right);

            quicksort(ref array, left, partitionIndex - 1);
            quicksort(ref array, partitionIndex + 1, right);
        }
    }
}