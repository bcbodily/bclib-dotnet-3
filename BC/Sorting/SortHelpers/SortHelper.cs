using System;

namespace BC.Sorting.SortHelpers
{
    /// <summary>
    /// A basic ISortHelper
    /// </summary>
    /// <typeparam name="T">the type of element this sort helper works with</typeparam>
    public class SortHelper<T> : ISortHelper<T> where T : IComparable<T>
    {
        ///<inheritdoc/>
        public int Compare(T[] array, int left, int right) =>
            array[left].CompareTo(array[right]);

        ///<inheritdoc/>
        public void Swap(ref T[] array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        ///<inheritdoc/>
        public void Write(ref T[] array, int index, T value)
        {
            array[index] = value;
        }
    }
}