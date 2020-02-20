using System;

namespace BC.Sorting
{
    /// <summary>
    /// An interface to a partioner that partions an array into three parts, separated by a left index and a right index
    /// </summary>
    /// <typeparam name="T">the type of elements in the array being partioned</typeparam>
    public interface IPartitionerThreeWay<T> where T : IComparable<T>
    {
        /// <summary>
        /// Partions the array, and returns the indices of the elements that separate the three parts
        /// </summary>
        /// <param name="array">the array to be partioned</param>
        /// <param name="left">the index of the left-most element of the portion of the array to be partioned</param>
        /// <param name="right">the index of the right-most element of the portion of the array to be partioned</param>
        /// <returns>a tuple containing the indices of the elements that separate the three parts</returns>
        (int left, int right) Partition(ref T[] array, int left, int right);
    }
}