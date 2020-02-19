using System;
using Xunit;

namespace BC.Sort
{
    public class InsertionSortTests
    {
        /// <summary>
        /// Verifies <see cref="InsertionSort.InsertionSort(ISortHelper{T})"/> when the <see cref="ISortHelper"/> is null, properly throws an <see cref="ArgumentException"/>
        /// </summary>
        [Fact]
        public void Constructor_ISortHelper_is_null_throws_exception()
        {
            ISortHelper<int> sortHelper = null;

            Assert.Null(sortHelper);

            Assert.Throws<ArgumentException>(() => new InsertionSort<int>(sortHelper));
        }

    }
}