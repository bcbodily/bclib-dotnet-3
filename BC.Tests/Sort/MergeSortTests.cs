using System;
using Xunit;


namespace BC.Sort
{
    public class MergeSortTests
    {

        [Fact]
        public void a()
        {
            var instance = new MergeSort<int>(new InstrumentedSortHelper<int>(new SortHelper<int>()));
            int[] array = new int[] { 1, 3, 6, 2, 4, 5 };

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };

            instance.MergeSortedRanges(ref array, 0, array.Length / 2, array.Length);

            Assert.Equal(expected, array);
        }
    }
}