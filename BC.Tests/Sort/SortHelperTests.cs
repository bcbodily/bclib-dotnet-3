using System;
using Xunit;
using Moq;

namespace BC.Sort
{
    /// <summary>
    /// An interface that implements IComparable with itself, that can be mocked for testing
    /// </summary>
    public interface ComparableClass : IComparable<ComparableClass>
    { }

    public class SortHelperTests
    {
        /// <summary>
        /// Verifies SortHelper.Compare, when the indices are in bounds, properly returns the result of calling CompareTo on the element at the left index with the element at the right index as an argument
        /// </summary>
        /// <param name="valToReturn">the value to configure the mocked left element to return in response to calling CompareTo with the element at the right index as an argument</param>
        [Theory]
        [InlineData(312)]
        [InlineData(411)]
        public void Compare_indices_are_in_bounds_calls_left_CompareTo_right(int valToReturn)
        {
            var leftMock = new Mock<ComparableClass>();
            var rightMock = new Mock<ComparableClass>();
            int returnVal = valToReturn;
            leftMock.Setup(a => a.CompareTo(rightMock.Object)).Returns(returnVal);
            ComparableClass[] array = new ComparableClass[2];
            array[0] = leftMock.Object;
            array[1] = rightMock.Object;

            var actual = new SortHelper<ComparableClass>().Compare(array, 0, 1);
            var expected = returnVal;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies SortHelper.Swap, when the indices are in bounds, properly results in a case where, after the operation, the element at the left index is the element that was at the right index, before the swap
        /// </summary>
        /// <param name="left">the index to use for the left element</param>
        /// <param name="right">the index to use for the right element</param>
        /// <param name="size">the size of the test array that should be created</param>
        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(8, 9, 10)]
        public void Swap_indices_are_in_bounds_newLeft_is_oldRight(int left, int right, int size)
        {
            var array = GetTestArray(size);
            var oldRight = array[right];

            // ensure the post-action values aren't equal due to pre-action equality
            Assert.NotEqual(array[left], array[right]);

            // ensure that the indices are in bounds
            Assert.InRange(left, 0, array.Length - 1);
            Assert.InRange(right, 0, array.Length - 1);

            new SortHelper<int>().Swap(ref array, left, right);

            var actual = array[left];
            var expected = oldRight;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies SortHelper.Swap, when the indices are in bounds, properly results in a case where, after the operation, the element at the right index is the element that was at the left index, before the swap
        /// </summary>
        /// <param name="left">the index to use for the left element</param>
        /// <param name="right">the index to use for the right element</param>
        /// <param name="size">the size of the test array that should be created</param>
        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(8, 9, 10)]
        public void Swap_indices_are_in_bounds_newRight_is_oldLeft(int left, int right, int size)
        {
            var array = GetTestArray(size);
            var oldLeft = array[left];

            // ensure the post-action values aren't equal due to pre-action equality
            Assert.NotEqual(array[left], array[right]);

            // ensure that the indices are in bounds
            Assert.InRange(left, 0, array.Length - 1);
            Assert.InRange(right, 0, array.Length - 1);

            new SortHelper<int>().Swap(ref array, left, right);

            var actual = array[right];
            var expected = oldLeft;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Gets an array if ints, with no two elements equal
        /// </summary>
        /// <param name="size">the size of the array to create</param>
        /// <returns>an int array of the specified size, with no two elements equal</returns>
        private int[] GetTestArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            return array;
        }
    }
}