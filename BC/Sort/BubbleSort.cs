using System;

namespace BC.Sort
{
    /// <summary>
    /// A bubble sort sorting algorithm
    /// </summary>
    /// <typeparam name="T">the type of elements this sort works with</typeparam>
    public class BubbleSort<T> : IArraySort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="BubbleSort{T}"/> with a specified <see cref="ISortHelper{T}"/>
        /// </summary>
        /// <param name="sortHelper">the <see cref="ISortHelper{T}"/> this sort will use to perform basic operations</param>
        public BubbleSort(ISortHelper<T> sortHelper)
        {
            SortHelper = sortHelper;
        }

        /// <summary>
        /// a <see cref="ISortHelper"/> that performs basic operations
        /// </summary>
        /// <value>the <see cref="ISortHelper"/> this sort uses to perform basic operations</value>
        private ISortHelper<T> SortHelper { get; }

        ///<inheritdoc/>
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