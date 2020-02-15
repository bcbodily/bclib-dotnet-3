using System;

namespace BC.Sort
{
    /// <summary>
    /// Interface to an object that can sort arrays
    /// </summary>
    /// <typeparam name="T">the type of element the sorting object works with</typeparam>
    public interface IArraySort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts a specified array
        /// </summary>
        /// <param name="array">the array to sort</param>
        public void Sort(T[] array);
    }
}