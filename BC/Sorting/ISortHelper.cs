using System;

namespace BC.Sorting
{
    /// <summary>
    /// An interface to a sorting helper class that implements compares and swaps of array elements
    /// </summary>
    /// <typeparam name="T">the type of elements in the array being sorted</typeparam>
    public interface ISortHelper<T> where T : IComparable<T>
    {
        /// <summary>
        /// Compares two elements within an array
        /// </summary>
        /// <param name="array">the array containing the elements to be compared</param>
        /// <param name="left">the index of the element to be compared against</param>
        /// <param name="right">the index of the element to be compared to</param>
        /// <returns>a value less than zero, if the right element comes before the left element, in the sorting order; a value greater than zero if the right element comes after the left element, in the sorting order; otherwise, zero</returns>
        public int Compare(T[] array, int left, int right);

        /// <summary>
        /// Swaps two elements within an array
        /// </summary>
        /// <param name="array">the array containing the elements to be swapped</param>
        /// <param name="left">the index of the first element</param>
        /// <param name="right">the index of the second element</param>
        public void Swap(ref T[] array, int left, int right);

        /// <summary>
        /// Writes a specified value to an specified index within an array
        /// </summary>
        /// <param name="array">the array containing the element to be written to</param>
        /// <param name="index">the index of the element to be written to</param>
        /// <param name="value">the value to write</param>
        public void Write(ref T[] array, int index, T value);
    }
}