using System;
using BC.Sorting.SortHelpers;
using Xunit;

namespace BC.Sorting.Partitioners
{
    public class LomutoPartionerTests
    {
        /// <summary>
        /// Verifies <see cref="LomutoPartitioner.LomutoPartitioner(ISortHelper{T})"/> when the <see cref="ISortHelper"/> is null, properly throws an <see cref="ArgumentException"/>
        /// </summary>
        [Fact]
        public void Constructor_ISortHelper_is_null_throws_exception()
        {
            ISortHelper<int> sortHelper = null;

            Assert.Null(sortHelper);

            Assert.Throws<ArgumentException>(() => new LomutoPartitioner<int>(sortHelper));
        }

        /// <summary>
        /// Verifies <see cref="LomutoPartitioner.Partition(ref T[], int, int)"/> properly returns a partition index for which all elements that come before the partition index are less than or equal to the element stored at the partition index
        /// </summary>
        /// <param name="size">the size of the array to create for testing</param>
        [Theory]
        [InlineData(10)]
        public void Partition_all_elements_before_partition_are_equal_to_or_less_than(int size)
        {
            var array = GetTestArray(size);

            var partition = new LomutoPartitioner<int>(new SortHelper<int>()).Partition(ref array, 0, array.Length - 1);
            var partitionValue = array[partition];
            for (int i = 0; i < partition; i++)
            {
                Assert.True(array[i].CompareTo(partitionValue) <= 0);
            }
        }

        /// <summary>
        /// Verifies <see cref="LomutoPartitioner.Partition(ref T[], int, int)"/> properly returns a partition index for which all elements that come after the partition index are greater than or equal to the element stored at the partition index
        /// </summary>
        /// <param name="size">the size of the array to create for testing</param>
        [Theory]
        [InlineData(10)]
        public void Partition_all_elements_after_partition_are_greater_than_or_equal_to(int size)
        {
            var array = GetTestArray(size);

            var partition = new LomutoPartitioner<int>(new SortHelper<int>()).Partition(ref array, 0, array.Length - 1);
            var partitionValue = array[partition];
            for (int i = partition + 1; i < array.Length; i++)
            {
                Assert.False(array[i].CompareTo(partitionValue) >= 0);
            }
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