using System;

namespace BC.Sort
{
    /// <summary>
    /// An interface to a partioner that partions an array into two parts, separated by a single index
    /// </summary>
    /// <typeparam name="T">the type of elements in the array being partioned</typeparam>
    public interface IPartionerTwoWay<T> where T : IComparable<T>
    {
        /// <summary>
        /// Partions the array, and returns the index of the element that separates the two parts
        /// </summary>
        /// <param name="array">the array to be partioned</param>
        /// <param name="left">the index of the left-most element of the portion of the array to be partioned</param>
        /// <param name="right">the index of the right-most element of the portion of the array to be partioned</param>
        /// <returns>the index of the element that separates the two parts</returns>
        int Partition(ref T[] array, int left, int right);
    }
}