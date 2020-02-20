using System;
using BC.Sorting.SortHelpers;
using Xunit;

namespace BC.Sorting.Sorts
{
    /// <summary>
    /// Unit tests for <see cref="BubbleSort"/>
    /// </summary>
    public class BubbleSortTests
    {
        /// <summary>
        /// Verifies <see cref="BubbleSort.Sort(T[])"/> properly sorts an array comprised of elements in order
        /// </summary>
        /// <param name="size">the size of the test array to use</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public void Sort_sorts_inOrder_array(int size)
        {
            var array = SortDriver.GetTestArrayInOrder(size);

            new BubbleSort<int>(new SortHelper<int>()).Sort(array);

            Assert.True(SortDriver.IsSorted(array));
        }

        /// <summary>
        /// Verifies <see cref="BubbleSort.Sort(T[])"/> properly sorts an array comprised of elements in random order
        /// </summary>
        /// <param name="size">the size of the test array to use</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public void Sort_sorts_random_array(int size)
        {
            var array = SortDriver.GetTestArrayRandomOrder(size);

            new BubbleSort<int>(new SortHelper<int>()).Sort(array);

            Assert.True(SortDriver.IsSorted(array));
        }

        /// <summary>
        /// Verifies <see cref="BubbleSort.Sort(T[])"/> properly sorts an array comprised of elements in reverse order
        /// </summary>
        /// <param name="size">the size of the test array to use</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public void Sort_sorts_reverse_array(int size)
        {
            var array = SortDriver.GetTestArrayReverseOrder(size);

            new BubbleSort<int>(new SortHelper<int>()).Sort(array);

            Assert.True(SortDriver.IsSorted(array));
        }
    }
}