using System;

namespace BC.Sorting.Sorts
{
    /// <summary>
    /// An insertion sorting algorithm
    /// </summary>
    /// <typeparam name="T">the type of elements this sort works with</typeparam>
    public class InsertionSort<T> : IArraySort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="InsertionSort"/> with a specified <see cref="ISortHelper"/>
        /// </summary>
        /// <param name="sortHelper">the <see cref="ISortHelper"/> this instance will use to perform basic operations</param>
        public InsertionSort(ISortHelper<T> sortHelper)
        {
            if (sortHelper == null)
            {
                throw new ArgumentException("illegal null 'sortHelper'; 'sortHelper' must be non-null");
            }

            SortHelper = sortHelper;
        }

        private ISortHelper<T> SortHelper { get; }

        /// <inheritDoc/>
        public void Sort(T[] array)
        {
            var right = 1;
            while (right < array.Length)
            {
                var left = right;
                while (left > 0 && SortHelper.Compare(array, left - 1, left) > 0)
                {
                    SortHelper.Swap(ref array, left, --left);
                }
                right++;
            }
        }
    }
}