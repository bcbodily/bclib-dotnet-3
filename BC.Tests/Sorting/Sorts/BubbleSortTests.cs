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